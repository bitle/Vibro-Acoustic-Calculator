using System;
using ExportToRTF;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using Diplom.Data;

namespace Diplom
{
    public partial class MainForm : Form
    {
        private const string XML_FILENAME = "saved_state.xml";
        private Research currentResearch = null;
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void btnAddTopView_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "jpg";
            open.Filter = "Изображения |*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            DialogResult res = open.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                pbTopView.ImageLocation = open.FileName;
                btnDelTopView.Enabled = true;
                btnRefreshTopView.Enabled = true;
                btnZoomTopView.Enabled = true;

                currentResearch.FrontViewPath = open.FileName;
            }
            
        }

        private void btnAddSideView_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "jpg";
            open.Filter = "Изображения |*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            DialogResult res = open.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                pbSideView.ImageLocation = open.FileName;
                btnDelSideView.Enabled = true;
                btnRefreshSideView.Enabled = true;
                btnZoomSideView.Enabled = true;

                currentResearch.SideViewPath = open.FileName;
            }            
        }

        private void btnZoomTopView_Click(object sender, EventArgs e)
        {
            Form zoom = new Form();
            PictureBox pb = new PictureBox();
            pb.ImageLocation = pbTopView.ImageLocation;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Parent = zoom;
            pb.Dock = DockStyle.Fill;
            zoom.WindowState = FormWindowState.Maximized;
            zoom.Show();
        }

        private void btnZoomSideView_Click(object sender, EventArgs e)
        {
            Form zoom = new Form();
            PictureBox pb = new PictureBox();
            pb.ImageLocation = pbSideView.ImageLocation;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Parent = zoom;
            pb.Dock = DockStyle.Fill;
            zoom.WindowState = FormWindowState.Maximized;
            zoom.Show();
        }

        private void btnRefreshTopView_Click(object sender, EventArgs e)
        {
            pbTopView.Load();
        }

        private void btnRefreshSideView_Click(object sender, EventArgs e)
        {
            pbSideView.Load();
        }

        private void btnDelTopView_Click(object sender, EventArgs e)
        {
            currentResearch.FrontViewPath = "";
            researchUpdated();
        }

        private void btnDelSideView_Click(object sender, EventArgs e)
        {
            currentResearch.SideViewPath = "";
            researchUpdated();
        }

        private void btnAddAcousticKT_Click(object sender, EventArgs e)
        {
            FormAddAcoustickKT form = new FormAddAcoustickKT();
            DialogResult res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //lstAcousticList.Items.Add(form.KTName);
                switch (form.Type)
                {
                    case KTType.Outside:
                        Outside outside = new Outside();
                        outside.ShowDialog();
                        CPOutside cp = new CPOutside(form.KTName);
                        getDataFromOutside(cp, outside);

                        currentResearch.CheckPoints.Add(cp);
                        researchUpdated();
                        break;
                    case KTType.Neighbor:

                        FormNeigborRooms neighbor = new FormNeigborRooms();
                        neighbor.ShowDialog();
                        CPNeighbor cpn = new CPNeighbor(form.KTName);

                        getDataFromNeighbor(cpn, neighbor);
                        currentResearch.CheckPoints.Add(cpn);
                        researchUpdated();
                        break;
                    case KTType.Vent:
                        FormVent vent = new FormVent();
                        vent.ShowDialog();
                        CPVent cpVent = new CPVent(form.KTName);
                        getDataFromVent(cpVent, vent);
                        currentResearch.CheckPoints.Add(cpVent);
                        researchUpdated();
                        break;
                    case KTType.Vibro:
                        FormVibro vibro = new FormVibro();
                        vibro.ShowDialog();
                        CPVibro cpVibro = new CPVibro(form.KTName);
                        getDataFromVibro(cpVibro, vibro);
                        currentResearch.CheckPoints.Add(cpVibro);
                        researchUpdated();
                        break;
                }
            }
        }

        private void lstAcousticList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAcousticList.SelectedIndex != -1)
            {
                btnDelAcousticKT.Enabled = true;
                btnEditKT.Enabled = true;
                btnRenameKT.Enabled = true;
            }
            else
            {
                btnDelAcousticKT.Enabled = false;
                btnEditKT.Enabled = false;
                btnRenameKT.Enabled = false;
            }
        }

        private void btnDelAcousticKT_Click(object sender, EventArgs e)
        {
            //lstAcousticList.Items.RemoveAt(lstAcousticList.SelectedIndex);
            if (lstAcousticList.SelectedIndex != -1)
            {
                currentResearch.CheckPoints.RemoveAt(lstAcousticList.SelectedIndex);
                researchUpdated();
            }
            else
            {
                btnDelAcousticKT.Enabled = false;
            }
        }

        private void btnAddNewResearch_Click(object sender, EventArgs e)
        {
            FormAddResearch form = new FormAddResearch();
            DialogResult res = form.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                lstResearches.Items.Add(new Research(form.ResearchName));
            }
        }

        private void lstResearches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResearches.SelectedIndex != -1)
            {
                currentResearch = (Research)lstResearches.SelectedItem;
                researchUpdated();
            }
        }

        private void btnDeleteResearch_Click(object sender, EventArgs e)
        {
            lstResearches.Items.RemoveAt(lstResearches.SelectedIndex);
            currentResearch = null;
            researchUpdated();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(XML_FILENAME);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            XmlNodeList list = doc.SelectNodes("/saved_data/research");
            foreach (XmlNode node in list)
            {
                Research research = new Research(node.SelectSingleNode("name").FirstChild.Value);
                try
                {
                    research.FrontViewPath = node.SelectSingleNode("front_view").FirstChild.Value;
                    research.SideViewPath = node.SelectSingleNode("side_view").FirstChild.Value;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Изображения не были сохранены");
                }

                XmlNodeList cp_nodes = node.SelectNodes("KT/*");
                if (cp_nodes != null)
                {
                    foreach (XmlNode cp in cp_nodes)
                    {
                        try
                        {
                            switch (cp.Name)
                            {
                                case "outside":
                                    research.CheckPoints.Add(loadOutside(cp));
                                    break;
                                case "vent":
                                    research.CheckPoints.Add(loadVent(cp));
                                    break;
                                case "neighbor":
                                    research.CheckPoints.Add(loadNeighbor(cp));
                                    break;
                                case "vibro":
                                    research.CheckPoints.Add(loadVibro(cp));
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                        
                }

                lstResearches.Items.Add(research);
            }
            researchUpdated();
        }

        private int getIntValue(XmlNode node, string tag)
        {
            try
            {
                return Int32.Parse(node.SelectSingleNode(tag).FirstChild.Value);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private double getDoubleValue(XmlNode node, string tag)
        {
            try
            {
                return Double.Parse(node.SelectSingleNode(tag).FirstChild.Value);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private CPOutside loadOutside(XmlNode cp)
        {
            CPOutside outside = new CPOutside(cp.SelectSingleNode("name").FirstChild.Value);
            outside.SignalLevelIndex = getIntValue(cp, "signal_level");
            outside.NoiseTypeIndex = getIntValue(cp, "noise_type");

            foreach (XmlNode reflector_node in cp.SelectNodes("reflectors/*"))
            {
                CPOutside.Reflector reflector = new CPOutside.Reflector();
                reflector.square = getDoubleValue(reflector_node, "square");
                reflector.MaterialIndex = getIntValue(reflector_node, "material");
                outside.reflectorsList.Add(reflector);
            }

            foreach (XmlNode absorber_node in cp.SelectNodes("absorbers/*"))
            {
                CPOutside.Reflector absorber = new CPOutside.Reflector();
                absorber.square = getDoubleValue(absorber_node, "square");
                absorber.MaterialIndex = getIntValue(absorber_node, "ratio");
                outside.absorbersList.Add(absorber);
            }

            foreach (XmlNode consumer_node in cp.SelectNodes("consumers/*"))
            {
                int consumer;
                consumer = Int32.Parse(consumer_node.FirstChild.Value);
                outside.consumersList.Add(consumer);
            }

            outside.Volume = getDoubleValue(cp, "volume");
            outside.RoomTypeIndex = getIntValue(cp, "room_type");
            outside.Distance = getDoubleValue(cp, "distance");
            outside.SoundFadingIndex = getIntValue(cp, "sound_fading");
            outside.AngleIndex = getIntValue(cp, "angle");
            outside.NoiseReduction = getIntValue(cp, "noise_reduction");
            outside.Microphone = getIntValue(cp, "microphone");
            outside.MicrophoneText = getDoubleValue(cp, "mic_value");

            outside.Results = ResearchResults.FromXml(cp.SelectSingleNode("results"));

            return outside;
        }

        private CPVent loadVent(XmlNode cp)
        {
            CPVent vent = new CPVent(cp.SelectSingleNode("name").FirstChild.Value);

            vent.SignalLevelIndex = Int32.Parse(cp.SelectSingleNode("signal_level").FirstChild.Value);
            vent.NoiseTypeIndex = Int32.Parse(cp.SelectSingleNode("noise_type").FirstChild.Value);

            vent.Distance = getDoubleValue(cp, "distance");
            vent.SignalPlace = getIntValue(cp, "signal_place");

            foreach (XmlNode absorber_node in cp.SelectNodes("absorbers/*"))
            {
                CPOutside.Reflector absorber = new CPOutside.Reflector();
                absorber.square = Double.Parse(absorber_node.SelectSingleNode("square").FirstChild.Value);
                absorber.MaterialIndex = Int32.Parse(absorber_node.SelectSingleNode("ratio").FirstChild.Value);
                vent.absorbersList.Add(absorber);
            }

            foreach (XmlNode consumer_node in cp.SelectNodes("consumers/*"))
            {
                int consumer;
                consumer = Int32.Parse(consumer_node.FirstChild.Value);
                vent.consumersList.Add(consumer);
            }

            vent.Volume = getDoubleValue(cp, "volume");
            
            vent.RoomTypeIndex = getIntValue(cp, "room_type");
            vent.NoiseReduction = getIntValue(cp, "noise_reduction");

            foreach (XmlNode sector_node in cp.SelectNodes("sectors/*"))
            {
                switch(sector_node.Name)
                {
                    case "beton":
                        FormVent.SectorBeton beton = new FormVent.SectorBeton();
                        beton.Length = getDoubleValue(sector_node, "length");
                        beton.Perimetr = getDoubleValue(sector_node, "perimetr");
                        beton.Square = getDoubleValue(sector_node, "square");
                        beton.RatioIndex = getIntValue(sector_node, "ratio");
                        vent.Sectors.Add(beton);
                        break;
                    case "metal":
                        FormVent.SectorMetal metal = new FormVent.SectorMetal();
                        metal.Length = getDoubleValue(sector_node, "length");
                        metal.FadingIndex = getIntValue(sector_node, "fading");
                        vent.Sectors.Add(metal);
                        break;
                    case "turn":
                        FormVent.SectorTurn turn = new FormVent.SectorTurn();
                        turn.AngleIndex = getIntValue(sector_node, "angle");
                        vent.Sectors.Add(turn);
                        break;
                    case "extension":
                        FormVent.SectorExtension extension = new FormVent.SectorExtension();
                        extension.SquareBefore = getDoubleValue(sector_node, "square_before");
                        extension.SquareAfter  = getDoubleValue(sector_node, "square_after");
                        vent.Sectors.Add(extension);
                        break;
                }
                //
            }

            vent.Results = ResearchResults.FromXml(cp.SelectSingleNode("results"));

            return vent;
        }

        private CPVibro loadVibro(XmlNode cp)
        {
            CPVibro vibro = new CPVibro(cp.SelectSingleNode("name").FirstChild.Value);

            vibro.SignalLevelIndex = getIntValue(cp, "signal_level");
            foreach (XmlNode absorber_node in cp.SelectNodes("absorbers/*"))
            {
                CPOutside.Reflector absorber = new CPOutside.Reflector();
                absorber.square = getDoubleValue(absorber_node, "square");
                absorber.MaterialIndex = getIntValue(absorber_node, "ratio");
                vibro.absorbersList.Add(absorber);
            }

            foreach (XmlNode consumer_node in cp.SelectNodes("consumers/*"))
            {
                int consumer;
                consumer = Int32.Parse(consumer_node.FirstChild.Value);
                vibro.consumersList.Add(consumer);
            }

            vibro.Volume = getDoubleValue(cp, "volume");
            vibro.RoomTypeIndex = getIntValue(cp, "room_type");
            vibro.Distance = getDoubleValue(cp, "distance");
            vibro.MaterialIndex = getIntValue(cp, "material");
            vibro.SignalPlaceIndex = getIntValue(cp, "signal_place");

            vibro.Results = ResearchResults.FromXml(cp.SelectSingleNode("results"));

            return vibro;
        }

        private CPNeighbor loadNeighbor(XmlNode cp)
        {
            CPNeighbor neigh = new CPNeighbor(cp.SelectSingleNode("name").FirstChild.Value);

            neigh.SignalLevelIndex = getIntValue(cp, "signal_level");
            neigh.NoiseTypeIndex = getIntValue(cp, "noise_type");

            foreach (XmlNode reflector_node in cp.SelectNodes("reflectors/*"))
            {
                CPOutside.Reflector reflector = new CPOutside.Reflector();
                reflector.square = getDoubleValue(reflector_node, "square");
                reflector.MaterialIndex = getIntValue(reflector_node, "material");
                neigh.reflectorsList.Add(reflector);
            }

            foreach (XmlNode absorber_node in cp.SelectNodes("absorbers/*"))
            {
                CPOutside.Reflector absorber = new CPOutside.Reflector();
                absorber.square = getDoubleValue(absorber_node, "square");
                absorber.MaterialIndex = getIntValue(absorber_node, "ratio");
                neigh.absorbersList.Add(absorber);
            }

            foreach (XmlNode consumer_node in cp.SelectNodes("consumers/*"))
            {
                int consumer;
                consumer = Int32.Parse(consumer_node.FirstChild.Value);
                neigh.consumersList.Add(consumer);
            }

            neigh.Volume = getDoubleValue(cp, "volume");
            neigh.RoomTypeIndex = getIntValue(cp, "room_type");
            neigh.NoiseReduction = getIntValue(cp, "noise_reduction");

            neigh.Results = ResearchResults.FromXml(cp.SelectSingleNode("results"));

            return neigh;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\" ?>"+
                "<saved_data></saved_data>");
            foreach (Research research in lstResearches.Items)
            {
                doc.DocumentElement.AppendChild(research.ToXml(doc));
            }
            doc.Save(XML_FILENAME);
        }

        private void researchUpdated()
        {
            updateTopView();
            updateSideView();

            updateCheckPoints();

            updateButtons();

            if (currentResearch != null && currentResearch.CheckPoints.Count == 0)
            {
                btnDelAcousticKT.Enabled = false;
                btnEditKT.Enabled = false;
                btnRenameKT.Enabled = false;
            }
        }

        private void updateButtons()
        {
            if (currentResearch != null && lstResearches.SelectedIndex != -1)
            {
                btnDeleteResearch.Enabled = true;
                btnReportResearch.Enabled = true;
                btnAddAcousticKT.Enabled = true;
                btnAddTopView.Enabled = true;
                btnAddSideView.Enabled = true;
            }
            else
            {//Если исследование не выбрано, то все кнопки становятся неактивными
                btnDeleteResearch.Enabled = false;
                btnReportResearch.Enabled = false;
                btnAddAcousticKT.Enabled = false;
                btnAddTopView.Enabled = false;
                btnAddSideView.Enabled = false;
            }
        }

        private void updateCheckPoints()
        {
            lstAcousticList.Items.Clear();
            if (currentResearch == null)
                return;
            foreach (CheckPoint cp in currentResearch.CheckPoints)
            {
                lstAcousticList.Items.Add(cp.Name);
            }
        }

        private void updateSideView()
        {
            if (currentResearch != null && currentResearch.SideViewPath != null)
            {//Если путь к изображению задан, то кнопки управления изображением становятся активными
                pbSideView.ImageLocation = currentResearch.SideViewPath;
                btnDelSideView.Enabled = true;
                btnRefreshSideView.Enabled = true;
                btnZoomSideView.Enabled = true;
            }
            else
            {//Если путь к изображению не задан, то кнопки управления изображением становятся неактивными
                pbSideView.ImageLocation = null;
                btnDelSideView.Enabled = false;
                btnRefreshSideView.Enabled = false;
                btnZoomSideView.Enabled = false;
            }
        }

        private void updateTopView()
        {

            if (currentResearch != null && currentResearch.FrontViewPath != null)
            {
                pbTopView.ImageLocation = currentResearch.FrontViewPath;
                btnDelTopView.Enabled = true;
                btnRefreshTopView.Enabled = true;
                btnZoomTopView.Enabled = true;
            }
            else
            {
                pbTopView.ImageLocation = null;
                btnDelTopView.Enabled = false;
                btnRefreshTopView.Enabled = false;
                btnZoomTopView.Enabled = false;
            }
        }

        private void lstResearches_DoubleClick(object sender, EventArgs e)
        {
            if (lstResearches.SelectedIndex == -1)
                return;
            FormAddResearch form = new FormAddResearch();
            form.Name = "Переименовать исследование";
            DialogResult res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                Research r = (Research)lstResearches.SelectedItem;
                r.Name = form.ResearchName;
                lstResearches.Items[lstResearches.SelectedIndex] = r;
            }
        }

        private void lstAcousticList_DoubleClick(object sender, EventArgs e)
        {
            if (lstAcousticList.SelectedIndex == -1)
                return;
            Type type = currentResearch.CheckPoints[lstAcousticList.SelectedIndex].GetType();
            if (type == Type.GetType("Diplom.Data.CPOutside"))
            {
                CPOutside cp = (CPOutside)currentResearch.CheckPoints[lstAcousticList.SelectedIndex];
                Outside outside = new Outside(cp);
                outside.ShowDialog();
                getDataFromOutside(cp, outside);
            }
            else if (type == Type.GetType("Diplom.Data.CPVibro"))
            {
                CPVibro cp = (CPVibro)currentResearch.CheckPoints[lstAcousticList.SelectedIndex];
                FormVibro outside = new FormVibro(cp);
                outside.ShowDialog();

                getDataFromVibro(cp, outside);
            }
            else if (type == Type.GetType("Diplom.Data.CPVent"))
            {
                CPVent cp = (CPVent)currentResearch.CheckPoints[lstAcousticList.SelectedIndex];
                FormVent vent = new FormVent(cp);
                vent.ShowDialog();

                getDataFromVent(cp, vent);
            }
            else if (type == Type.GetType("Diplom.Data.CPNeighbor"))
            {
                CPNeighbor cp = (CPNeighbor)currentResearch.CheckPoints[lstAcousticList.SelectedIndex];
                FormNeigborRooms outside = new FormNeigborRooms(cp);
                outside.ShowDialog();

                getDataFromNeighbor(cp, outside);
            }
        }

        private void getDataFromNeighbor(CPNeighbor cp, FormNeigborRooms outside)
        {
            cp.SignalLevelIndex = outside.SignalLevel;
            cp.NoiseTypeIndex = outside.NoiseType;
            cp.Volume = outside.Volume;
            cp.RoomTypeIndex = outside.RoomType;
            cp.NoiseReduction = outside.NoiseReduction;

            cp.reflectorsList = outside.Reflectors;
            cp.absorbersList = outside.Absorbers;
            cp.consumersList = outside.Consumers;

            cp.Results = outside.Result;
        }

        private void getDataFromVibro(CPVibro cp, FormVibro outside)
        {
            cp.SignalLevelIndex = outside.SignalLevel;
            cp.absorbersList = outside.Absorbers;
            cp.consumersList = outside.Consumers;
            cp.Volume = outside.Volume;
            cp.RoomTypeIndex = outside.RoomType;
            cp.Distance = outside.Distance;
            cp.MaterialIndex = outside.Material;
            cp.SignalPlaceIndex = outside.SignalPlace;

            cp.Results = outside.Result;
        }

        private void getDataFromOutside(CPOutside cp, Outside outside)
        {
            cp.SignalLevelIndex = outside.SignalLevel;
            cp.NoiseTypeIndex = outside.NoiseType;
            cp.Volume = outside.Volume;
            cp.RoomTypeIndex = outside.RoomType;
            cp.Distance = outside.Distance;
            cp.SoundFadingIndex = outside.SoundFading;
            cp.AngleIndex = outside.Angle;
            cp.Microphone = outside.Microphone;
            cp.MicrophoneText = outside.MicrophoneValue;
            cp.NoiseReduction = outside.NoiseReduction;

            cp.reflectorsList = outside.Reflectors;
            cp.absorbersList = outside.Absorbers;
            cp.consumersList = outside.Consumers;

            cp.Results = outside.Result;
        }

        private void getDataFromVent(CPVent cp, FormVent outside)
        {
            cp.SignalLevelIndex = outside.SignalLevel;
            cp.NoiseTypeIndex = outside.NoiseType;
            cp.Volume = outside.Volume;
            cp.RoomTypeIndex = outside.RoomType;
            cp.NoiseReduction = outside.NoiseReduction;

            cp.SignalPlace = outside.SignalPlace;
            cp.Distance = outside.Distance;

            cp.absorbersList = outside.Absorbers;
            cp.consumersList = outside.Consumers;

            cp.Results = outside.Result;
            cp.Sectors = outside.Sectors;
        }

        private void btnRenameKT_Click(object sender, EventArgs e)
        {
            FormAddResearch form = new FormAddResearch();
            form.Name = "Переименовать КТ";
            DialogResult res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                ((CheckPoint)currentResearch.CheckPoints[lstAcousticList.SelectedIndex]).Name = form.ResearchName;
                lstAcousticList.Items[lstAcousticList.SelectedIndex] = form.ResearchName;
            }
            
        }

        private void btnEditKT_Click(object sender, EventArgs e)
        {
            lstAcousticList_DoubleClick(sender, e);
        }

        private void btnReportResearch_Click(object sender, EventArgs e)
        {
            WordDocument doc = new WordDocument(WordDocumentFormat.A4);
            Font normal = new Font("Arial", 10, FontStyle.Regular);
            Font bold = new Font("Arial", 10, FontStyle.Bold);
            Font header = new Font("Arial", 16, FontStyle.Bold);
            Font subHeader = new Font("Arial", 16, FontStyle.Italic);
            Font subSubHeader = new Font("Arial", 12, FontStyle.Italic);

            doc.SetFont(header);
            doc.WriteLine("Протокол исследований объекта '" + currentResearch.Name + "'");
            doc.WriteLine();
            doc.SetFont(normal);

            const int PICTURE_WIDTH_IN_INCH = 8;

            int picture_number = 1;
            if (pbTopView.ImageLocation != null)
            {
                int DPI = pbTopView.Image.Width / PICTURE_WIDTH_IN_INCH;
                doc.PutImage(pbTopView.ImageLocation, DPI);
                doc.WriteLine();
                doc.SetTextAlign(WordTextAlign.Center);
                doc.WriteLine("Рисуное " + picture_number++ + ". Схема размещения контрольных точек. Вид сверху");
                doc.SetTextAlign(WordTextAlign.Left);
            }

            if (pbSideView.ImageLocation != null)
            {
                int DPI = pbSideView.Image.Width / PICTURE_WIDTH_IN_INCH;
                doc.PutImage(pbSideView.ImageLocation, DPI);
                doc.WriteLine();
                doc.SetTextAlign(WordTextAlign.Center);
                doc.WriteLine("Рисуное " + picture_number + ". Схема размещения контрольных точек. Вид сбоку");
                doc.SetTextAlign(WordTextAlign.Left);
            }

            
            doc.SetFont(normal);
            if (currentResearch.CheckPoints.Count > 0)
            {
                doc.SetFont(subHeader);
                doc.WriteLine("Контрольные точки: Акустика");
                doc.SetFont(normal);
            }

            

            foreach(CheckPoint cp in currentResearch.CheckPoints)
            {
                if (cp.GetType() == Type.GetType("Diplom.Data.CPVibro"))
                {
                    continue;
                }
                doc.SetFont(subSubHeader);
                doc.WriteLine("Контрольная точка '" + cp.Name + "'");
                doc.SetFont(normal);
                WordTable table = doc.NewTable(normal, Color.Black, 7, cp.Results.Ratio.Length + 1, 1);
                table.SetColumnsWidth(new int[8] { 5, 1, 1, 1, 1, 1, 1, 1 });
                table.CellRange(0, 0, 1, 0).MergeCells();
                NewCell(table, 0, 0, "Слагаемое", bold);
                table.CellRange(0, 1, 0, 7).MergeCells();
                NewCell(table, 0, 1, "Среднегеометрическая частота октавной полосы, Гц", bold);
                NewCell(table, 1, 1, "125", bold);
                NewCell(table, 1, 2, "250", bold);
                NewCell(table, 1, 3, "500", bold);
                NewCell(table, 1, 4, "1000", bold);
                NewCell(table, 1, 5, "2000", bold);
                NewCell(table, 1, 6, "4000", bold);
                NewCell(table, 1, 7, "8000", bold);

                int noiseLevelRow = 4;
                int ratioIndex = 5;
                int wIndex = 6;
                

                NewCell(table, 2, 0, "Уровеь сигнала, дБ", bold);
                NewCell(table, 3, 0, "Уровеь сигнала в КТ, дБ", bold);
                NewCell(table, 4, 0, "Уровеь шума, дБ", bold);
                NewCell(table, ratioIndex, 0, "Отношение сигнал/шум, дБ", bold);

                for (int i = 1; i <= cp.Results.Ratio.Length; i++)
                {
                    NewCell(table, 2, i, cp.Results.SignalLevel[i - 1].ToString());
                    NewCell(table, 3, i, cp.Results.SoundproofLefel[i - 1].ToString());
                    NewCell(table, noiseLevelRow, i, cp.Results.NoiseLevel[i - 1].ToString());
                    NewCell(table, ratioIndex, i, cp.Results.Ratio[i - 1].ToString());                    
                }
                table.SaveToDocument(10000, 0);

                NewCell(table, wIndex, 0, "Словесная разборчиваость речи, %", bold);
                table.CellRange(wIndex, 1, wIndex, 7).MergeCells();
                NewCell(table, wIndex, 1, cp.Results.W.ToString());
                doc.WriteLine();
            }

            if (currentResearch.CheckPoints.Count > 0)
            {
                doc.SetFont(subHeader);
                doc.WriteLine("Контрольные точки: Виброакустика");
                doc.SetFont(normal);
            }

            foreach (CheckPoint cp in currentResearch.CheckPoints)
            {
                if (cp.GetType() != Type.GetType("Diplom.Data.CPVibro"))
                {
                    continue;
                }

                doc.SetFont(subSubHeader);
                doc.WriteLine("Контрольная точка '" + cp.Name + "'");
                doc.SetFont(normal);
                WordTable table = doc.NewTable(normal, Color.Black, 6, 6, 1);
                table.SetColumnsWidth(new int[6] { 5, 1, 1, 1, 1, 1});
                table.CellRange(0, 0, 1, 0).MergeCells();
                NewCell(table, 0, 0, "Слагаемое", bold);
                table.CellRange(0, 1, 0, 5).MergeCells();
                NewCell(table, 0, 1, "Среднегеометрическая частота октавной полосы, Гц", bold);
                NewCell(table, 1, 1, "250", bold);
                NewCell(table, 1, 2, "500", bold);
                NewCell(table, 1, 3, "1000", bold);
                NewCell(table, 1, 4, "2000", bold);
                NewCell(table, 1, 5, "4000", bold);

                int ratioIndex = 4;
                int wIndex = 5;
                

                NewCell(table, 2, 0, "Уровеь сигнала, дБ", bold);
                NewCell(table, 3, 0, "Уровеь сигнала в КТ, дБ", bold);
                NewCell(table, ratioIndex, 0, "Отношение сигнал/шум, дБ", bold);

                for (int i = 1; i <= 6; i++)
                {
                    NewCell(table, 2, i, cp.Results.SignalLevel[i].ToString());
                    NewCell(table, 3, i, cp.Results.SoundproofLefel[i].ToString());
                    NewCell(table, ratioIndex, i, cp.Results.Ratio[i].ToString());
                }
                table.SaveToDocument(10000, 0);

                NewCell(table, wIndex, 0, "Словесная разборчиваость речи, %", bold);
                table.CellRange(wIndex, 1, wIndex, 5).MergeCells();
                NewCell(table, wIndex, 1, cp.Results.W.ToString());
                doc.WriteLine();
            }

            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "doc";
            sf.Filter = "Документ Word |*.doc";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                doc.SaveToFile(sf.FileName);
                MessageBox.Show("Отчет сформирован");
            }            
        }

        private void NewCell(WordTable table, int row, int col, string text)
        {
            table.Cell(row, col).Write(text);
            table.Cell(row, col).SetBorders(Color.Black, 1, true, true, true, true);
        }
        private void NewCell(WordTable table, int row, int col, string text, Font font)
        {
            table.Cell(row, col).Write(text);
            table.Cell(row, col).SetFont(font);
            table.Cell(row, col).SetBorders(Color.Black, 1, true, true, true, true);
        }
    }
}
