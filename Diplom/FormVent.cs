using System;
using System.Collections;
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
    public partial class FormVent : Form
    {
        public FormVent()
        {
            InitializeComponent();

            cbSignalLevel.Items.Clear();
            cbSignalLevel.Items.Add(new Row("Тихая речь", new int[] { 47, 60, 60, 55, 50, 47, 43 }));
            cbSignalLevel.Items.Add(new Row("Речь средней громкости", new int[] { 53, 66, 66, 61, 56, 53, 49 }));
            cbSignalLevel.Items.Add(new Row("Громкая речь", new int[] { 59, 72, 72, 67, 62, 59, 55 }));
            cbSignalLevel.Items.Add(new Row("Очень громкая речь", new int[] { 67, 80, 80, 75, 70, 67, 63 }));

            cbNoiseType.Items.Clear();
            cbNoiseType.Items.Add(new Row("Помещения офисов, рабочие помещения административных зданий (днем)", new int[] { 57, 49, 44, 40, 37, 35, 33 }));
            cbNoiseType.Items.Add(new Row("Помещение тихое, днем", new int[] { 48, 40, 34, 30, 27, 25, 23 }));
            cbNoiseType.Items.Add(new Row("Помещение тихое, ночью", new int[] { 39, 31, 24, 20, 17, 14, 13 }));
            cbNoiseType.Items.Add(new Row("Территории, непосредственно прилегающие к зданиям со стороны улицы со средним движением", new int[] { 66, 59, 54, 50, 47, 45, 44 }));
            cbNoiseType.Items.Add(new Row("Территории, непосредственно прилегающие к зданиям со стороны улицы без движения", new int[] { 57, 49, 44, 40, 37, 35, 33 }));

            colConsumersSquare.Items.Clear();
            consumers.Add(new RowFloat("Один человек", new double[] { 0, 33, 0.41, 0.44, 0.46, 0.46, 0.46 }));
            consumers.Add(new RowFloat("Два человека", new double[] { 0.25, 0.44, 0.78, 0.97, 1.0, 1.0, 1.0 }));
            consumers.Add(new RowFloat("Три человека", new double[] { 0.2, 0.33, 0.67, 0.84, 0.92, 0.97, 0.97 }));
            consumers.Add(new RowFloat("Кресло бархатное", new double[] { 0.14, 0.22, 0.31, 0.4, 0.52, 0.6, 0.6 }));
            consumers.Add(new RowFloat("Кресло деревянное", new double[] { 0.02, 0.02, 0.02, 0.04, 0.04, 0.03, 0.03 }));
            consumers.Add(new RowFloat("Кресло кожаное", new double[] { 0.1, 0.12, 0.17, 0.17, 0.12, 0.1, 0.1 }));
            consumers.Add(new RowFloat("Стул мягкий", new double[] { 0.05, 0.09, 0.12, 0.13, 0.15, 0.16, 0.15 }));
            consumers.Add(new RowFloat("Стул полумягкий", new double[] { 0.05, 0.08, 0.18, 0.15, 0.17, 0.15, 0.05 }));
            consumers.Add(new RowFloat("Стул жесткий", new double[] { 0.02, 0.02, 0.02, 0.02, 0.02, 0.02, 0.02 }));

            foreach (RowFloat r in consumers)
            {
                colConsumersSquare.Items.Add(r.ToString());
            }

            colAbsorbRatio.Items.Clear();
            absorbers.Add(new RowFloat("Кирпичная стена неокрашенная", new double[] { 0.02, 0.03, 0.03, 0.04, 0.05, 0.05, 0.05 }));
            absorbers.Add(new RowFloat("Кирпичная стена окрашенная", new double[] { 0.01, 0.01, 0.02, 0.02, 0.02, 0.03, 0.03 }));
            absorbers.Add(new RowFloat("Бетонная стена литая неокрашенная", new double[] { 0.01, 0.01, 0.02, 0.02, 0.02, 0.04, 0.04 }));
            absorbers.Add(new RowFloat("Бетонная стена окрашенная", new double[] { 0.01, 0.01, 0.01, 0.02, 0.02, 0.02, 0.02 }));
            absorbers.Add(new RowFloat("Штукатурка акустическая", new double[] { 0.22, 0.27, 0.31, 0.31, 0.33, 0.4, 0.4 }));
            absorbers.Add(new RowFloat("Штукатурка гипсовая", new double[] { 0.02, 0.03, 0.04, 0.06, 0.06, 0.03, 0.03 }));
            absorbers.Add(new RowFloat("Штукатурка известковая", new double[] { 0.02, 0.05, 0.06, 0.09, 0.04, 0.06, 0.06 }));
            absorbers.Add(new RowFloat("Штукатурка по обрешетке", new double[] { 0.02, 0.02, 0.03, 0.04, 0.04, 0.04, 0.04 }));
            absorbers.Add(new RowFloat("Древесностружечная плита (20 мм) вплотную к стене", new double[] { 0.01, 0.09, 0.09, 0.08, 0.09, 0.14, 0.14 }));
            absorbers.Add(new RowFloat("Древесно-стружечная плита (20 мм) на 100 мм от стены", new double[] { 0.27, 0.08, 0.04, 0.02, 0.08, 0.1, 0.16 }));
            absorbers.Add(new RowFloat("Древесно-стружечная плита оклеенная пластиком на 100 мм от стены", new double[] { 0.29, 0.22, 0.1, 0.08, 0.11, 0.06, 0.07 }));
            absorbers.Add(new RowFloat("Древесноволокнистые плиты (12 мм)", new double[] { 0.22, 0.3, 0.34, 0.32, 0.41, 0.42, 0.42 }));
            absorbers.Add(new RowFloat("Панель гипсовая (10 мм) на 100 мм от стены", new double[] { 0.41, 0.28, 0.15, 0.06, 0.05, 0.02, 0.02 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (18 мм) вплотную к стене", new double[] { 0.02, 0.14, 0.65, 0.9, 0.87, 0.86, 0.92 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (18 мм) на 100 мм от стены", new double[] { 0.28, 0.81, 0.86, 0.87, 0.89, 0.86, 0.88 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (10 мм) вплотную к стене", new double[] { 0.08, 0.24, 0.59, 0.66, 0.66, 0.6, 0.56 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (10 мм) на 100 мм от стены", new double[] { 0.24, 0.76, 0.59, 0.54, 0.62, 0.66, 0.66 }));
            absorbers.Add(new RowFloat("Плиты «Акмигран» (20 мм)  вплотную к стене", new double[] { 0.05, 0.19, 0.56, 0.78, 0.82, 0.85, 0.7 }));
            absorbers.Add(new RowFloat("Плиты «Акмигран» ( 20 мм) на 100 мм от стены", new double[] { 0.29, 0.7, 0.68, 0.68, 0.75, 0.74, 0.7 }));
            absorbers.Add(new RowFloat("Фанерная обшивка", new double[] { 0.12, 0.11, 0.06, 0.08, 0.09, 0.12, 0.12 }));
            absorbers.Add(new RowFloat("Фанерная обшивка с обоями", new double[] { 0.104, 0.1, 0.06, 0.07, 0.07, 0.07, 0.07 }));
            absorbers.Add(new RowFloat("Деревянные панели", new double[] { 0.08, 0.07, 0.06, 0.06, 0.06, 0.06, 0.06 }));
            absorbers.Add(new RowFloat("Деревянная обшивка (сосна)", new double[] { 0.1, 0.11, 0.1, 0.08, 0.08, 0.11, 0.11 }));
            absorbers.Add(new RowFloat("Щиты Бекеши (холст на вате толщиной 40 мм)", new double[] { 0.8, 0.81, 0.73, 0.51, 0.46, 0.45, 0.45 }));
            absorbers.Add(new RowFloat("Драпировка х/б у стены", new double[] { 0.05, 0.12, 0.35, 0.45, 0.38, 0.36, 0.36 }));
            absorbers.Add(new RowFloat("Драпировка х/б на 20 см от стены", new double[] { 0.08, 0.29, 0.44, 0.5, 0.4, 0.35, 0.35 }));
            absorbers.Add(new RowFloat("Вентиляционная решетка", new double[] { 0.5, 0.5, 0.4, 0.35, 0.3, 0.25, 0.25 }));
            absorbers.Add(new RowFloat("Пол бетонный", new double[] { 0.01, 0.01, 0.02, 0.02, 0.02, 0.02, 0.02 }));
            absorbers.Add(new RowFloat("Пол деревянный", new double[] { 0.05, 0.04, 0.03, 0.03, 0.03, 0.03, 0.05 }));
            absorbers.Add(new RowFloat("Пол, покрытый линолеумом", new double[] { 0.02, 0.03, 0.03, 0.04, 0.04, 0.05, 0.02 }));
            absorbers.Add(new RowFloat("Пол паркетный ", new double[] { 0.04, 0.04, 0.07, 0.06, 0.06, 0.07, 0.07 }));
            absorbers.Add(new RowFloat("Пол паркетный на шпонках", new double[] { 0.2, 0.15, 0.12, 0.1, 0.08, 0.07, 0.06 }));
            absorbers.Add(new RowFloat("Пол деревянный, натертый мастикой", new double[] { 0.15, 0.11, 0.1, 0.07, 0.06, 0.07, 0.06 }));
            absorbers.Add(new RowFloat("Метлахская плитка", new double[] { 0.01, 0.01, 0.02, 0.02, 0.02, 0.03, 0.03 }));
            absorbers.Add(new RowFloat("Мрамор или плитка", new double[] { 0.01, 0.01, 0.01, 0.02, 0.02, 0.01, 0.01 }));
            absorbers.Add(new RowFloat("Ковер на подкладке", new double[] { 0.1, 0.2, 0.25, 0.3, 0.4, 0.4, 0.4 }));
            absorbers.Add(new RowFloat("Ковер без подкладки", new double[] { 0.08, 0.1, 0.15, 0.2, 0.25, 0.25, 0.25 }));
            absorbers.Add(new RowFloat("Ковер с ворсом (10 мм) на бетоне", new double[] { 0.09, 0.08, 0.21, 0.27, 0.27, 0.37, 0.37 }));
            absorbers.Add(new RowFloat("Ковер шерстяной с ворсом ( 8 мм)", new double[] { 0.02, 0.05, 0.26, 0.47, 0.54, 0.7, 0.71 }));
            absorbers.Add(new RowFloat("Ковер капроновый ( 8 мм)", new double[] { 0.04, 0.04, 0.21, 0.45, 0.55, 0.62, 0.64 }));
            absorbers.Add(new RowFloat("Дорожка ковровая безворсовая", new double[] { 0.02, 0.05, 0.07, 0.11, 0.29, 0.48, 0.5 }));
            absorbers.Add(new RowFloat("Ковер-плюш", new double[] { 0.09, 0.08, 0.21, 0.26, 0.27, 0.37, 0.37 }));
            absorbers.Add(new RowFloat("Оконное стекло ", new double[] { 0.04, 0.03, 0.03, 0.02, 0.02, 0.02, 0.04 }));
            absorbers.Add(new RowFloat("Застекленные оконные переплеты", new double[] { 0.35, 0.25, 0.18, 0.12, 0.07, 0.04, 0.03 }));
            absorbers.Add(new RowFloat("Занавеси легкие", new double[] { 0.04, 0.08, 0.11, 0.25, 0.3, 0.3, 0.3 }));
            absorbers.Add(new RowFloat("Занавеси тяжелые", new double[] { 0.1, 0.27, 0.5, 0.8, 0.82, 0.75, 0.75 }));
            absorbers.Add(new RowFloat("Занавес из тарной ткани", new double[] { 0.02, 0.07, 0.19, 0.42, 0.48, 0.3, 0.44 }));
            absorbers.Add(new RowFloat("Занавес из репса", new double[] { 0.02, 0.09, 0.38, 0.68, 0.66, 0.6, 0.5 }));
            absorbers.Add(new RowFloat("Занавес «Маркиза»", new double[] { 0.07, 0.16, 0.29, 0.46, 0.5, 0.52, 0.55 }));
            absorbers.Add(new RowFloat("Двери лакированные", new double[] { 0.03, 0.02, 0.05, 0.04, 0.04, 0.04, 0.04 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из стекловол. «Шуманет-СК», без относа", new double[] { 0.26, 0.67, 1.0, 1.0, 0.99, 0.9, 0.9 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из стекловол. «Шуманет-СК», с относом 50 мм от стены", new double[] { 0.54, 0.92, 1.0, 1.0, 0.9, 0.83, 0.83 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из минваты «Шуманет-БМ», без относа", new double[] { 0.26, 0.67, 1.0, 1.0, 0.99, 0.9, 0.9 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из минваты «Шуманет-БМ», с относом 50 мм от стены", new double[] { 0.54, 0.92, 1.0, 1.0, 0.9, 0.83, 0.83 }));

            foreach (RowFloat r in absorbers)
            {
                colAbsorbRatio.Items.Add(r.ToString());
            }


            


            

            
        }

        public FormVent(CPVent data) : this()
        {
            cbSignalLevel.SelectedIndex = data.SignalLevelIndex;
            cbNoiseType.SelectedIndex = data.NoiseTypeIndex;

            tbDistance.Text = data.Distance.ToString();
            cbSignalPlace.SelectedIndex = data.SignalPlace;

            tbAbsorbersNumber.Text = data.absorbersList.Count.ToString();
            dgvAbsorber.Rows.Clear();
            foreach (CPOutside.Reflector r in data.absorbersList)
            {
                int new_row = dgvAbsorber.Rows.Add();

                dgvAbsorber.Rows[new_row].Cells[0].Value = r.square.ToString();
                dgvAbsorber.Rows[new_row].Cells[1].Value = ((DataGridViewComboBoxCell)dgvAbsorber.Rows[new_row].Cells[1]).Items[r.MaterialIndex];
            }

            tbConsumersNumber.Text = data.consumersList.Count.ToString();
            dgvConsumers.Rows.Clear();
            foreach (int index in data.consumersList)
            {
                int new_row = dgvConsumers.Rows.Add();
                dgvConsumers.Rows[new_row].Cells[0].Value = ((DataGridViewComboBoxCell)dgvConsumers.Rows[new_row].Cells[0]).Items[index];
            }

            tbNeighborVolume.Text = data.Volume.ToString();
            cbRoomType.SelectedIndex = data.RoomTypeIndex;

            switch (data.NoiseReduction)
            {
                case 0:
                    rbNone.Checked = true;
                    break;
                case 1:
                    rbStrongNoiseReduction.Checked = true;
                    break;
                case 2:
                    rbWeakNoiseReduction.Checked = true;
                    break;
            }

            foreach (Sector s in data.Sectors)
            {
                lstSegments.Items.Add(s);
            }

            tbSoundprofLevel125.Text = data.Results.SoundproofLefel[0].ToString();
            tbSoundprofLevel250.Text = data.Results.SoundproofLefel[1].ToString();
            tbSoundprofLevel500.Text = data.Results.SoundproofLefel[2].ToString();
            tbSoundprofLevel1000.Text = data.Results.SoundproofLefel[3].ToString();
            tbSoundprofLevel2000.Text = data.Results.SoundproofLefel[4].ToString();
            tbSoundprofLevel4000.Text = data.Results.SoundproofLefel[5].ToString();
            tbSoundprofLevel8000.Text = data.Results.SoundproofLefel[6].ToString();

            tbRatio125.Text = data.Results.Ratio[0].ToString();
            tbRatio250.Text = data.Results.Ratio[1].ToString();
            tbRatio500.Text = data.Results.Ratio[2].ToString();
            tbRatio1000.Text = data.Results.Ratio[3].ToString();
            tbRatio2000.Text = data.Results.Ratio[4].ToString();
            tbRatio4000.Text = data.Results.Ratio[5].ToString();
            tbRatio8000.Text = data.Results.Ratio[6].ToString();

            tbReadability.Text = data.Results.W.ToString();
        }
        
        private void FormVent_Load(object sender, EventArgs e)
        {
            
        }

        private void tbAbsorbersNumber_TextChanged(object sender, EventArgs e)
        {
            onTextChanged((TextBox)sender, dgvAbsorber);
        }

        private ArrayList consumers = new ArrayList();
        private ArrayList absorbers = new ArrayList();

        private void onTextChanged(TextBox tb, DataGridView dgv)
        {
            int n = 0;
            if (tb.Text == "")
                return;
            if (Int32.TryParse(tb.Text, out n))
            {
                if (0 < n && n < 100)
                {
                    tb.BackColor = Color.White;
                    dgv.Rows.Clear();
                    for (; n > 0; n--)
                    {
                        dgv.Rows.Add();
                    }
                }
                else
                {
                    tb.BackColor = Color.Red;
                    tb.Text = "";
                }
            }
            else
            {
                tb.BackColor = Color.Red;
                tb.Text = "";
            }
        }

        private void tbConsumersNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int n = 0;
            if (tb.Text == "")
                return;
            if (Int32.TryParse(tb.Text, out n))
            {
                if (0 <= n && n < 100)
                {
                    tb.BackColor = Color.White;
                    dgvConsumers.Rows.Clear();
                    for (; n > 0; n--)
                    {
                        dgvConsumers.Rows.Add();
                    }
                }
                else
                {
                    tb.BackColor = Color.Red;
                    tb.Text = "";
                }
            }
            else
            {
                tb.BackColor = Color.Red;
                tb.Text = "";
            }
        }

        public abstract class Sector
        {
            public abstract double getDeltaLm(int freq);
            public abstract XmlElement ToXml(XmlDocument doc);
        }

        public class SectorTurn : Sector
        {
            public SectorTurn() 
            {
                lst_turn.Add(new RowFloat("угол не более 45 градусов", new double[] { 0, 0, 0, 0, 0, 0, 0 }));
                lst_turn.Add(new RowFloat("угол более 45 град. ширина поворота 125 мм", new double[] { 0, 0, 1, 5, 7, 5, 3 }));
                lst_turn.Add(new RowFloat("угол более 45 град. ширина поворота 250 мм", new double[] { 0, 1, 5, 7, 5, 3, 3 }));
                lst_turn.Add(new RowFloat("угол более 45 град. ширина поворота 500 мм", new double[] { 1, 5, 7, 5, 3, 3, 3 }));
                lst_turn.Add(new RowFloat("угол более 45 град. ширина поворота 1000 мм", new double[] { 5, 7, 5, 3, 3, 3, 3 }));
                lst_turn.Add(new RowFloat("угол более 45 град. ширина поворота 2000 мм", new double[] { 7, 5, 3, 3, 3, 3, 3 }));
            }
            public int AngleIndex
            {
                get
                {
                    return index;
                }
                set
                {
                    index = value;
                }
            }
            public RowFloat Angle { get { return lst_turn[index]; } }
            public override string ToString()
            {
                return "Поворот";
            }

            public override double getDeltaLm(int freq)
            {
                return Angle.Values[freq];
            }
            public override XmlElement ToXml(XmlDocument doc)
            {
                XmlElement turn = doc.CreateElement("turn");
                XmlElement angle = doc.CreateElement("angle");
                angle.AppendChild(doc.CreateTextNode(AngleIndex.ToString()));
                turn.AppendChild(angle);
                return turn;
            }

            private List<RowFloat> lst_turn = new List<RowFloat>();
            private int index;
        }

        public class SectorExtension : Sector
        {
            public double SquareBefore { get; set; }
            public double SquareAfter { get; set; }
            public override string ToString()
            {
                return "Расширение/Сужение";
            }

            public override double getDeltaLm(int freq)
            {
                double m = SquareBefore / SquareAfter;
                return 10*Math.Log10((m+1)*(m+1)/4*m);
            }

            public override XmlElement ToXml(XmlDocument doc)
            {
                XmlElement extension = doc.CreateElement("extension");

                XmlElement sqare_before = doc.CreateElement("square_before");
                sqare_before.AppendChild(doc.CreateTextNode(SquareBefore.ToString()));
                extension.AppendChild(sqare_before);

                XmlElement sqare_after = doc.CreateElement("square_after");
                sqare_after.AppendChild(doc.CreateTextNode(SquareAfter.ToString()));
                extension.AppendChild(sqare_after);

                return extension;
            }
        }

        abstract public class SectorStraight : Sector
        {
            public double Length { get; set; }
            public override string ToString()
            {
                return "Прямой участок";
            }
        }

        public class SectorMetal : SectorStraight
        {
            public SectorMetal()
            {
                lst_signal_fading.Add(new RowFloat("Прямоугольное, диаметр 75-200", new double[] { 0.6, 0.45, 0.3, 0.3, 0.3, 0.3, 0.3 }));
                lst_signal_fading.Add(new RowFloat("Прямоугольное, диаметр 210-00", new double[] { 0.6, 0.45, 0.3, 0.2, 0.2, 0.2, 0.2 }));
                lst_signal_fading.Add(new RowFloat("Прямоугольное, диаметр 410-800", new double[] { 0.6, 0.3, 0.15, 0.15, 0.15, 0.15, 0.15 }));
                lst_signal_fading.Add(new RowFloat("Прямоугольное, диаметр 810-1600", new double[] { 0.3, 0.15, 0.1, 0.06, 0.06, 0.06, 0.06 }));
                lst_signal_fading.Add(new RowFloat("Круглое, диаметр 75-200", new double[] { 0.1, 0.15, 0.3, 0.3, 0.3, 0.3, 0.3 }));
                lst_signal_fading.Add(new RowFloat("Круглое, диаметр 210-400", new double[] { 0.1, 0.1, 0.15, 0.2, 0.2, 0.2, 0.2 }));
                lst_signal_fading.Add(new RowFloat("Круглое, диаметр 410-800", new double[] { 0.06, 0.06, 0.1, 0.15, 0.15, 0.15, 0.15 }));
                lst_signal_fading.Add(new RowFloat("Круглое, диаметр 810-1600", new double[] { 0.03, 0.03, 0.06, 0.06, 0.06, 0.06, 0.06 }));
            }
            public int FadingIndex
            {
                get
                {
                    return index;
                }
                set
                {
                    index = value;
                }
            }
            public RowFloat Fading { get { return lst_signal_fading[index]; } }
            public override string ToString()
            {
                return "Прямой участок (Металл)";
            }
            public override double getDeltaLm(int freq)
            {
                return Fading.Values[freq]*Length;
            }

            public override XmlElement ToXml(XmlDocument doc)
            {
                XmlElement metal = doc.CreateElement("metal");

                XmlElement fading = doc.CreateElement("fading");
                fading.AppendChild(doc.CreateTextNode(FadingIndex.ToString()));
                metal.AppendChild(fading);

                XmlElement length = doc.CreateElement("length");
                length.AppendChild(doc.CreateTextNode(Length.ToString()));
                metal.AppendChild(length);

                return metal;
            }

            private int index;
            private List<RowFloat> lst_signal_fading = new List<RowFloat>();
        }

        public class SectorBeton : SectorStraight
        {
            public SectorBeton()
            {
                lst_fade_ratio.Add(new RowFloat("Кирпичный или бетонный канал", new double[] { 0.09, 0.11, 0.15, 0.18, 0.22, 0.27, 0.32 }));
                lst_fade_ratio.Add(new RowFloat("Канал с ребристым перекрытием", new double[] { 0.55, 0.65, 0.8, 0.9, 1, 1.1, 1.2 }));
                lst_fade_ratio.Add(new RowFloat("Кабельный коллектор", new double[] { 0.64, 0.86, 1.07, 1.3, 1.5, 1.7, 1.95 }));
            }
            public int RatioIndex
            {
                get
                {
                    return index;
                }
                set
                {
                    index = value;
                }
            }
            public RowFloat Ratio { get { return lst_fade_ratio[index]; } }
            public double Square { get; set; }
            public double Perimetr { get; set; }

            public override string ToString()
            {
                return "Прямой участок (Бетон)";
            }

            public override double getDeltaLm(int freq)
            {
                return Ratio.Values[freq] * Length * Perimetr / (4 * Square);
            }

            public override XmlElement ToXml(XmlDocument doc)
            {
                XmlElement beton = doc.CreateElement("beton");

                XmlElement length = doc.CreateElement("length");
                length.AppendChild(doc.CreateTextNode(Length.ToString()));
                beton.AppendChild(length);

                XmlElement ratio = doc.CreateElement("ratio");
                ratio.AppendChild(doc.CreateTextNode(RatioIndex.ToString()));
                beton.AppendChild(ratio);

                XmlElement square = doc.CreateElement("square");
                square.AppendChild(doc.CreateTextNode(Square.ToString()));
                beton.AppendChild(square);

                XmlElement perimetr = doc.CreateElement("perimetr");
                perimetr.AppendChild(doc.CreateTextNode(Perimetr.ToString()));
                beton.AppendChild(perimetr);

                return beton;
            }

            private int index;
            private List<RowFloat> lst_fade_ratio = new List<RowFloat>();
        }

        private void lstSegments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSegments.SelectedIndex != -1)
            {
                btnEditSector.Enabled = true;
                btnRemoveSector.Enabled = true;
            }
            else
            {
                btnEditSector.Enabled = false;
                btnRemoveSector.Enabled = false;
            }
        }

        private void btnAddSector_Click(object sender, EventArgs e)
        {
            FormAddSegment form = new FormAddSegment();
            DialogResult res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                lstSegments.Items.Add(form.Data);
            }
        }

        private void btnRemoveSector_Click(object sender, EventArgs e)
        {
            if (lstSegments.SelectedIndex >= 0)
                lstSegments.Items.RemoveAt(lstSegments.SelectedIndex);
        }

        private void btnEditSector_Click(object sender, EventArgs e)
        {
            int index = lstSegments.SelectedIndex;
            if (index >= 0)
            {
                FormAddSegment form = new FormAddSegment((Sector)lstSegments.SelectedItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    lstSegments.Items.RemoveAt(index);
                    lstSegments.Items.Insert(index, form.Data);
                }
            }
        }
        public ResearchResults Result
        {
            get
            {
                ResearchResults res = new ResearchResults();
                try
                {
                    res.W = Double.Parse(tbReadability.Text);

                    res.Ratio[0] = Double.Parse(tbRatio125.Text);
                    res.Ratio[1] = Double.Parse(tbRatio250.Text);
                    res.Ratio[2] = Double.Parse(tbRatio500.Text);
                    res.Ratio[3] = Double.Parse(tbRatio1000.Text);
                    res.Ratio[4] = Double.Parse(tbRatio2000.Text);
                    res.Ratio[5] = Double.Parse(tbRatio4000.Text);
                    res.Ratio[6] = Double.Parse(tbRatio8000.Text);

                    res.SoundproofLefel[0] = Double.Parse(tbSoundprofLevel125.Text);
                    res.SoundproofLefel[1] = Double.Parse(tbSoundprofLevel250.Text);
                    res.SoundproofLefel[2] = Double.Parse(tbSoundprofLevel500.Text);
                    res.SoundproofLefel[3] = Double.Parse(tbSoundprofLevel1000.Text);
                    res.SoundproofLefel[4] = Double.Parse(tbSoundprofLevel2000.Text);
                    res.SoundproofLefel[5] = Double.Parse(tbSoundprofLevel4000.Text);
                    res.SoundproofLefel[6] = Double.Parse(tbSoundprofLevel8000.Text);

                    Row r = (Row)cbSignalLevel.SelectedItem;
                    for (int i = 0; i < r.Values.Length; i++)
                        res.SignalLevel[i] = r.Values[i];

                    Row noise_type = (Row)cbNoiseType.SelectedItem;
                    for (int i = 0; i < r.Values.Length; i++)
                        res.NoiseLevel[i] = noise_type.Values[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return res;
            }
        }
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                updateSignalLevelKT();
                updateRatios();
                updateReadability();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void updateSignalLevelKT()
        {
            tbSoundprofLevel125.Text = L(0).ToString("F1");
            tbSoundprofLevel250.Text = L(1).ToString("F1");
            tbSoundprofLevel500.Text = L(2).ToString("F1");
            tbSoundprofLevel1000.Text = L(3).ToString("F1");
            tbSoundprofLevel2000.Text = L(4).ToString("F1");
            tbSoundprofLevel4000.Text = L(5).ToString("F1");
            tbSoundprofLevel8000.Text = L(6).ToString("F1");
        }

        private double updateRatio(TextBox SoundproofLevel, TextBox NoiseLevel, int freq)
        {
            double t1 = Double.Parse(SoundproofLevel.Text);
            double t2 = Double.Parse(NoiseLevel.Text);

            if (noiseReduction == NoiseReductionEnum.None)
                return t1 - t2;
            else
                return t1 - t2 + (noiseReduction == NoiseReductionEnum.Strong ? (new double[] { 2.5, 7.0, 7.0, 6.0, 3.0, 1.5, 0.5 })[freq] : (new double[] { 1.5, 4.0, 4.0, 3.0, 1.5, 0.5, 0.2 })[freq]);
        }

        private NoiseReductionEnum noiseReduction = NoiseReductionEnum.None;

        private enum NoiseReductionEnum
        {
            None,
            Weak,
            Strong
        }
        
        private void updateRatios()
        {
            tbRatio125.Text = updateRatio(tbSoundprofLevel125, tbNoiseLevel125, 0).ToString("F1");
            tbRatio250.Text = updateRatio(tbSoundprofLevel250, tbNoiseLevel250, 1).ToString("F1");
            tbRatio500.Text = updateRatio(tbSoundprofLevel500, tbNoiseLevel500, 2).ToString("F1");
            tbRatio1000.Text = updateRatio(tbSoundprofLevel1000, tbNoiseLevel1000, 3).ToString("F1");
            tbRatio2000.Text = updateRatio(tbSoundprofLevel2000, tbNoiseLevel2000, 4).ToString("F1");
            tbRatio4000.Text = updateRatio(tbSoundprofLevel4000, tbNoiseLevel4000, 5).ToString("F1");
            tbRatio8000.Text = updateRatio(tbSoundprofLevel8000, tbNoiseLevel8000, 6).ToString("F1");
        }

        private void updateReadability()
        {

            double[] q = new double[7];
            try
            {
                q[0] = Double.Parse(tbRatio125.Text);
                q[1] = Double.Parse(tbRatio250.Text);
                q[2] = Double.Parse(tbRatio500.Text);
                q[3] = Double.Parse(tbRatio1000.Text);
                q[4] = Double.Parse(tbRatio2000.Text);
                q[5] = Double.Parse(tbRatio4000.Text);
                q[6] = Double.Parse(tbRatio8000.Text);
            }
            catch (FormatException e)
            {
                MessageBox.Show("Ошибка в заполнении текстового поля 'Отношение сигнал-шум'");
                throw new Exception();
            }
            double[] p = new double[7];
            double R = 0;
            double[] Q = new double[7];
            for (int i = 0; i < q.Length; i++)
            {
                Q[i] = q[i] - (new double[] { 25, 18, 14, 9, 6, 5, 4 })[i];
                if (Q[i] <= 0)
                {
                    p[i] = (0.78 + 5.46 * Math.Exp(-4.3 * 0.001 * Math.Pow(27.3 - Math.Abs(Q[i]), 2))) / (1 + Math.Pow(10, 0.1 * Math.Abs(Q[i])));
                }
                else
                {
                    p[i] = 1 - (0.78 + 5.46 * Math.Exp(-4.3 * 0.001 * Math.Pow(27.3 - Math.Abs(Q[i]), 2))) / (1 + Math.Pow(10, 0.1 * Math.Abs(Q[i])));
                }

                R += p[i] * (new double[] { 0.01, 0.03, 0.12, 0.2, 0.3, 0.26, 0.07 })[i];
            }

            double W = 0;
            if (R < 0.15)
            {
                W = 1.54 * Math.Pow(R, 0.25) * (1 - Math.Exp(-11 * R));
            }
            else
            {
                W = 1 - Math.Exp((-11 * R) / (1 + 0.7 * R));
            }
            W *= 100;
            tbReadability.Text = W.ToString("F3");
        }

        #region math
        private double L(int freq)
        {
            double Lci = getLci(freq);//Получение уровня сигнала для заданной частоты
            double Omega = getOmega();//Получение поправки на расположение объекта
            double r = getR();//Получение расстояния до источника сигнала
            double alpha = getAvp(freq) / getS();//Средний коэффициент звукопоглощения помещения
            double k = 3.125 * alpha + 0.625;
            if (k < 1) k = 1;

            double B = getB();//акустическая постоянная выделенного помещения в октавной полосе

            double deltaL = getDeltaL(freq);//суммарное снижение уровня сигнала в октавной полосе на  трассе воздуховода

            return Lci + 10 * Math.Log10(1 / (Omega * r * r) + 4 / (k * B)) - deltaL;//Расчет уровня сигнала в КТ
        }

        //суммарное снижение уровня сигнала в октавной полосе на  трассе воздуховода
        private double getDeltaL(int freq)
        {
            double sum = 0;
            foreach(Sector s in lstSegments.Items)
                sum += s.getDeltaLm(freq);
            return sum;
        }

        private double getB()
        {
            double B = 0;
            try
            {
                B = Double.Parse(tbNeighborVolume.Text);
            }
            catch (FormatException)
            {
                throw new Exception("Неправильна введена площадь выделенного помещения");
            }
            switch (cbRoomType.SelectedIndex)
            {
                case 0:
                case 1:
                    B *= 0.1;
                    B += 2;
                    break;
                case 2:
                    B *= 0.17;
                    B += 3.3;
                    break;
                case 3:
                    B *= 0.64;
                    B += 1.6;
                    break;
                default:
                    throw new Exception("Не выбран тип выделенного помещения");
            }
            return B;
        }

        private double getLci(int freq)
        {
            try
            {
                Row r = (Row)cbSignalLevel.SelectedItem;
                return r.Values[freq];
            }
            catch (Exception)
            {
                throw new Exception("Не выбран Уровень сигнала источника");
            }
        }

        private double getOmega()
        {
            try
            {
                switch (cbSignalPlace.SelectedIndex)
                {
                    case 0:
                        return 4 * Math.PI;
                    case 1:
                        return 2 * Math.PI;
                    case 2:
                        return Math.PI;
                    default:
                        throw new Exception();
                }
            }
            catch (Exception)
            {
                throw new Exception("Не выбрано Расстояние источника сигнала");
            }
        }

        private double getR()
        {
            try
            {
                return Double.Parse(tbDistance.Text);
            }
            catch (Exception)
            {
                throw new Exception("Не правильно введено Расстояние от источника сигнала");
            }
        }

        //эквивалентная площадь звукопоглощения выделенного помещения
        private double getAvp(int freq)
        {
            int M = 0;
            try
            {
                M = Int32.Parse(tbAbsorbersNumber.Text);
            }
            catch (Exception)
            {
                throw new Exception("Не правильно задано Количество звукопоглащающих поверхностей");
            }

            double Asp = 0;
            try
            {
                for (int i = 0; i < M; i++)
                {
                    string s = (string)dgvAbsorber.Rows[i].Cells[1].Value;
                    RowFloat r = searchFor(s, absorbers);
                    Asp += Double.Parse(dgvAbsorber.Rows[i].Cells[0].Value.ToString()) * (r.Values[freq]);
                }
            }
            catch (FormatException)
            {
                throw new Exception("Неправильно введена Площадь звукопоглащающей поверхности");
            }
            catch (Exception)
            {
                throw new Exception("Неправильно введен Коэффициент звукопоглащения поверхности");
            }


            int L;
            try
            {
                L = Int32.Parse(tbConsumersNumber.Text);
            }
            catch (Exception)
            {
                throw new Exception("Неправильно введено Количество штучных поглотителей");
            }
            try
            {
                for (int i = 0; i < L; i++)
                {
                    string s = (string)dgvConsumers.Rows[i].Cells[0].Value;
                    RowFloat r = searchFor(s, consumers);
                    Asp += r.Values[freq];
                }
            }
            catch (Exception)
            {
                throw new Exception("Неправильно введена Эквивалентная площадь звукопоглащения поглотителя");
            }

            return Asp;
        }

        //Получение общей площади ограждающих поверхностей выделенного помещения
        private double getS()
        {
            int M = 0;
            try
            {
                M = Int32.Parse(tbAbsorbersNumber.Text);
            }
            catch (Exception)
            {
                throw new Exception("Не правильно задано Количество звукопоглащающих поверхностей");
            }

            try
            {
                double S = 0;
                for (int i = 0; i < M; i++)
                {
                    S += Double.Parse(dgvAbsorber.Rows[i].Cells[0].Value.ToString());
                }
                return S;
            }
            catch (Exception)
            {
                throw new Exception("Неправильно введена Площадь звукопоглащающей поверхности");
            }
        }
        #endregion

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNone.Checked)
                noiseReduction = NoiseReductionEnum.None;
            else if (rbStrongNoiseReduction.Checked)
                noiseReduction = NoiseReductionEnum.Strong;
            else if (rbWeakNoiseReduction.Checked)
                noiseReduction = NoiseReductionEnum.Weak;
        }

        private void cbSignalLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Row row = (Row)cbSignalLevel.SelectedItem;
            tbSignalLevel125.Text = row.Values[0].ToString();
            tbSignalLevel250.Text = row.Values[1].ToString();
            tbSignalLevel500.Text = row.Values[2].ToString();
            tbSignalLevel1000.Text = row.Values[3].ToString();
            tbSignalLevel2000.Text = row.Values[4].ToString();
            tbSignalLevel4000.Text = row.Values[5].ToString();
            tbSignalLevel8000.Text = row.Values[6].ToString();
        }

        private void cbNoiseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Row row = (Row)cbNoiseType.SelectedItem;
            tbNoiseLevel125.Text = row.Values[0].ToString();
            tbNoiseLevel250.Text = row.Values[1].ToString();
            tbNoiseLevel500.Text = row.Values[2].ToString();
            tbNoiseLevel1000.Text = row.Values[3].ToString();
            tbNoiseLevel2000.Text = row.Values[4].ToString();
            tbNoiseLevel4000.Text = row.Values[5].ToString();
            tbNoiseLevel8000.Text = row.Values[6].ToString();
        }

        private RowFloat searchFor(string s, ArrayList list)
        {
            foreach (RowFloat r in list)
            {
                if (r.Name.Equals(s))
                {
                    return r;
                }
            }
            return null;
        }

        public int SignalLevel
        {
            get
            {
                return cbSignalLevel.SelectedIndex;
            }
        }

        public int NoiseType
        {
            get
            {
                return cbNoiseType.SelectedIndex;
            }
        }

        public int SignalPlace
        {
            get
            {
                return cbSignalPlace.SelectedIndex;
            }
        }

        public double Distance
        {
            get
            {
                try
                {
                    return Double.Parse(tbDistance.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }

        public double Volume
        {
            get
            {
                try
                {
                    return Double.Parse(tbNeighborVolume.Text);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public int RoomType
        {
            get
            {
                return cbRoomType.SelectedIndex;
            }
        }

        public int NoiseReduction
        {
            get
            {
                if (rbNone.Checked)
                    return 0;
                else if (rbStrongNoiseReduction.Checked)
                    return 1;
                else if (rbWeakNoiseReduction.Checked)
                    return 2;
                return 0;
            }
        }

        public ArrayList Absorbers
        {
            get
            {
                ArrayList ret = new ArrayList();
                foreach (DataGridViewRow dgvr in dgvAbsorber.Rows)
                {
                    CPOutside.Reflector refl = new CPOutside.Reflector();
                    refl.square = Double.Parse(dgvr.Cells[0].Value.ToString());
                    refl.MaterialIndex = ((DataGridViewComboBoxCell)dgvr.Cells[1]).Items.IndexOf(dgvr.Cells[1].Value);
                    ret.Add(refl);
                }
                return ret;
            }
        }

        public ArrayList Consumers
        {
            get
            {
                ArrayList ret = new ArrayList();
                foreach (DataGridViewRow dgvr in dgvConsumers.Rows)
                {
                    int t = ((DataGridViewComboBoxCell)dgvr.Cells[0]).Items.IndexOf(dgvr.Cells[0].Value);
                    ret.Add(t);
                }
                return ret;
            }
        }

        public List<Sector> Sectors
        {
            get
            {
                List<Sector> ret = new List<Sector>();

                foreach (Sector s in lstSegments.Items)
                    ret.Add(s);

                return ret;
            }
        }

        public List<RowFloat> lst_fade_ration = new List<RowFloat>();

        public List<RowFloat> lst_signal_fading = new List<RowFloat>();

        public List<RowFloat> lst_turn = new List<RowFloat>();
    }    
}
