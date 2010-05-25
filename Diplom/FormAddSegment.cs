using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom
{
    public partial class FormAddSegment : Form
    {
        public FormAddSegment()
        {
            InitializeComponent();

            cbFadeRatio.Items.Add(new RowFloat("Кирпичный или бетонный канал", new double[] { 0.09, 0.11, 0.15, 0.18, 0.22, 0.27, 0.32 }));
            cbFadeRatio.Items.Add(new RowFloat("Канал с ребристым перекрытием", new double[] { 0.55, 0.65, 0.8, 0.9, 1, 1.1, 1.2 }));
            cbFadeRatio.Items.Add(new RowFloat("Кабельный коллектор", new double[] { 0.64, 0.86, 1.07, 1.3, 1.5, 1.7, 1.95 }));

            cbSignalFading.Items.Add(new RowFloat("Прямоугольное, диаметр 75-200", new double[] { 0.6, 0.45, 0.3, 0.3, 0.3, 0.3, 0.3 }));
            cbSignalFading.Items.Add(new RowFloat("Прямоугольное, диаметр 210-00", new double[] { 0.6, 0.45, 0.3, 0.2, 0.2, 0.2, 0.2 }));
            cbSignalFading.Items.Add(new RowFloat("Прямоугольное, диаметр 410-800", new double[] { 0.6, 0.3, 0.15, 0.15, 0.15, 0.15, 0.15 }));
            cbSignalFading.Items.Add(new RowFloat("Прямоугольное, диаметр 810-1600", new double[] { 0.3, 0.15, 0.1, 0.06, 0.06, 0.06, 0.06 }));
            cbSignalFading.Items.Add(new RowFloat("Круглое, диаметр 75-200", new double[] { 0.1, 0.15, 0.3, 0.3, 0.3, 0.3, 0.3 }));
            cbSignalFading.Items.Add(new RowFloat("Круглое, диаметр 210-400", new double[] { 0.1, 0.1, 0.15, 0.2, 0.2, 0.2, 0.2 }));
            cbSignalFading.Items.Add(new RowFloat("Круглое, диаметр 410-800", new double[] { 0.06, 0.06, 0.1, 0.15, 0.15, 0.15, 0.15 }));
            cbSignalFading.Items.Add(new RowFloat("Круглое, диаметр 810-1600", new double[] { 0.03, 0.03, 0.06, 0.06, 0.06, 0.06, 0.06 }));

            cbTurnAngleAndSize.Items.Add(new RowFloat("угол не более 45 градусов", new double[] { 0, 0, 0, 0, 0, 0, 0 }));
            cbTurnAngleAndSize.Items.Add(new RowFloat("угол более 45 град. ширина поворота 125 мм", new double[] { 0, 0, 1, 5, 7, 5, 3 }));
            cbTurnAngleAndSize.Items.Add(new RowFloat("угол более 45 град. ширина поворота 250 мм", new double[] { 0, 1, 5, 7, 5, 3, 3 }));
            cbTurnAngleAndSize.Items.Add(new RowFloat("угол более 45 град. ширина поворота 500 мм", new double[] { 1, 5, 7, 5, 3, 3, 3 }));
            cbTurnAngleAndSize.Items.Add(new RowFloat("угол более 45 град. ширина поворота 1000 мм", new double[] { 5, 7, 5, 3, 3, 3, 3 }));
            cbTurnAngleAndSize.Items.Add(new RowFloat("угол более 45 град. ширина поворота 2000 мм", new double[] { 7, 5, 3, 3, 3, 3, 3 }));

            panelStraight.Location = panelTurn.Location;
            panelExtention.Location = panelTurn.Location;
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public FormAddSegment(FormVent.Sector sector)
            : this()
        {
            Type type = sector.GetType();
            if (type == Type.GetType("Diplom.FormVent+SectorMetal"))
            {
                AddSegment((FormVent.SectorMetal)sector);
            }
            else if (type == Type.GetType("Diplom.FormVent+SectorBeton"))
            {
                AddSegment((FormVent.SectorBeton)sector);
            }
            else if (type == Type.GetType("Diplom.FormVent+SectorExtension"))
            {
                AddSegment((FormVent.SectorExtension)sector);
            }
            else if (type == Type.GetType("Diplom.FormVent+SectorTurn"))
            {
                AddSegment((FormVent.SectorTurn)sector);
            }
        }

        public void AddSegment(FormVent.SectorMetal sector)
        {
            rbStraight.Checked = true;

            panelStraight.Visible = true;
            panelTurn.Visible = false;
            panelExtention.Visible = false;

            cbStreightMaterial.SelectedIndex = 1;

            tbSegmentLength.Text = sector.Length.ToString();
            cbSignalFading.SelectedIndex = sector.FadingIndex;
        }
        public void AddSegment(FormVent.SectorBeton sector)
        {
            rbStraight.Checked = true;

            panelStraight.Visible = true;
            panelTurn.Visible = false;
            panelExtention.Visible = false;

            cbStreightMaterial.SelectedIndex = 0;

            tbSegmentLength.Text = sector.Length.ToString();
            tbSectorSquare.Text = sector.Square.ToString();
            tbSectorPerimetr.Text = sector.Perimetr.ToString();
            cbFadeRatio.SelectedIndex = sector.RatioIndex;
        }
        public void AddSegment(FormVent.SectorExtension sector)
        {
            rbExtension.Checked = true;

            panelStraight.Visible = false;
            panelTurn.Visible = false;
            panelExtention.Visible = true;

            tbSquareBeforeExt.Text = sector.SquareBefore.ToString();
            tbSquareAfterExt.Text = sector.SquareAfter.ToString();
        }
        public void AddSegment(FormVent.SectorTurn sector)
        {
            rbTurn.Checked = true;

            panelStraight.Visible = false;
            panelTurn.Visible = true;
            panelExtention.Visible = false;

            cbTurnAngleAndSize.SelectedIndex = sector.AngleIndex;
        }

        private void rbStraight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStraight.Checked)
            {
                panelStraight.Visible = true;
                panelTurn.Visible = false;
                panelExtention.Visible = false;
            }
            else if (rbTurn.Checked)
            {
                panelTurn.Visible = true;
                panelStraight.Visible = false;
                panelExtention.Visible = false;
            }
            else if (rbExtension.Checked)
            {
                panelExtention.Visible = true;
                panelStraight.Visible = false;
                panelTurn.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbStraight.Checked)
                {
                    try
                    {
                        Double.Parse(tbSegmentLength.Text);
                    }
                    catch
                    {
                        throw new Exception("Не правильно введена длина участка");
                    }
                    if (cbStreightMaterial.SelectedIndex == 1)
                    {
                        if (cbSignalFading.SelectedIndex < 0)
                        {
                            throw new Exception("Не выбрано Погонное затухание акуст. сигнала");
                        }
                    }
                    else if (cbStreightMaterial.SelectedIndex == 0)
                    {
                        if (cbFadeRatio.SelectedIndex < 0)
                        {
                            throw new Exception("Не выбран Коэффициент затухания акустического сигнала");
                        }
                        try
                        {
                            Double.Parse(tbSectorSquare.Text);
                        }
                        catch
                        {
                            throw new Exception("Не правильно введена площадь поперечного сечения канала");
                        }
                        try
                        {
                            Double.Parse(tbSectorPerimetr.Text);
                        }
                        catch
                        {
                            throw new Exception("Не правильно введен Периметр поперечного сечения канала");
                        }
                    }
                    else
                    {
                        throw new Exception("Не выбран материал участка");
                    }
                }
                else if (rbTurn.Checked)
                {
                    if (cbTurnAngleAndSize.SelectedIndex < 0)
                    {
                        throw new Exception("Не выбран Угол поворота");
                    }
                }
                else if (rbExtension.Checked)
                {
                    try
                    {
                        Double.Parse(tbSquareBeforeExt.Text);
                    }
                    catch
                    {
                        throw new Exception("Не правильно введена площадь поперечного сечения до изменения сегмента");
                    }
                    try
                    {
                        Double.Parse(tbSquareAfterExt.Text);
                    }
                    catch
                    {
                        throw new Exception("Не правильно введена площадь поперечного сечения после изменения сегмента");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        public FormVent.Sector Data
        {
            get
            {
                if (rbStraight.Checked)
                {
                    if (cbStreightMaterial.SelectedIndex < 0)
                        return null;
                    else if (cbStreightMaterial.SelectedIndex == 0)
                    {
                        FormVent.SectorBeton beton = new FormVent.SectorBeton();
                        beton.Length = Double.Parse(tbSegmentLength.Text);
                        beton.Perimetr = Double.Parse(tbSectorPerimetr.Text);
                        beton.Square = Double.Parse(tbSectorSquare.Text);
                        beton.RatioIndex = cbFadeRatio.SelectedIndex;
                        return beton;
                    }
                    else if (cbStreightMaterial.SelectedIndex == 1)
                    {
                        FormVent.SectorMetal metal = new FormVent.SectorMetal();
                        metal.Length = Double.Parse(tbSegmentLength.Text);
                        metal.FadingIndex = cbSignalFading.SelectedIndex;
                        return metal;
                    }
                    return null;
                }
                else if (rbTurn.Checked)
                {
                    FormVent.SectorTurn turn = new FormVent.SectorTurn();
                    turn.AngleIndex = cbTurnAngleAndSize.SelectedIndex;
                    return turn;
                }
                else if (rbExtension.Checked)
                {
                    FormVent.SectorExtension ext = new FormVent.SectorExtension();
                    try
                    {
                        ext.SquareBefore = Double.Parse(tbSquareBeforeExt.Text);
                        ext.SquareAfter = Double.Parse(tbSquareAfterExt.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                    return ext;
                }
                return null;
            }
        }

        private void cbStreightMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStreightMaterial.SelectedIndex == 0)
            {
                panelStraightBeton.Visible = true;
                panelStraightMetal.Visible = false;
            }
            else if (cbStreightMaterial.SelectedIndex == 1)
            {
                panelStraightBeton.Visible = false;
                panelStraightMetal.Visible = true;
            }
        }
    }
}
