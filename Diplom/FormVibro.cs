using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Diplom.Data;

namespace Diplom
{
    public partial class FormVibro : Form
    {
        public FormVibro()
        {
            InitializeComponent();
            MaximizeBox = false;

            cbSignalLevel.Items.Clear();
            cbSignalLevel.Items.Add(new Row("Тихая речь", new int[] { 60, 60, 55, 50, 47 }));
            cbSignalLevel.Items.Add(new Row("Речь средней громкости", new int[] { 66, 66, 61, 56, 53 }));
            cbSignalLevel.Items.Add(new Row("Громкая речь", new int[] { 72, 72, 67, 62, 59 }));
            cbSignalLevel.Items.Add(new Row("Очень громкая речь", new int[] { 80, 80, 75, 70, 67 }));

            colConsumersSquare.Items.Clear();
            consumers.Add(new RowFloat("Один человек", new double[] { 33, 0.41, 0.44, 0.46, 0.46 }));
            consumers.Add(new RowFloat("Два человека", new double[] { 0.44, 0.78, 0.97, 1.0, 1.0 }));
            consumers.Add(new RowFloat("Три человека", new double[] { 0.33, 0.67, 0.84, 0.92, 0.97 }));
            consumers.Add(new RowFloat("Кресло бархатное", new double[] { 0.22, 0.31, 0.4, 0.52, 0.6 }));
            consumers.Add(new RowFloat("Кресло деревянное", new double[] { 0.02, 0.02, 0.04, 0.04, 0.03 }));
            consumers.Add(new RowFloat("Кресло кожаное", new double[] { 0.12, 0.17, 0.17, 0.12, 0.1 }));
            consumers.Add(new RowFloat("Стул мягкий", new double[] { 0.09, 0.12, 0.13, 0.15, 0.16 }));
            consumers.Add(new RowFloat("Стул полумягкий", new double[] { 0.08, 0.18, 0.15, 0.17, 0.15 }));
            consumers.Add(new RowFloat("Стул жесткий", new double[] { 0.02, 0.02, 0.02, 0.02, 0.02 }));

            foreach (RowFloat r in consumers)
            {
                colConsumersSquare.Items.Add(r.ToString());
            }

            colAbsorbRatio.Items.Clear();
            absorbers.Add(new RowFloat("Кирпичная стена неокрашенная", new double[] { 0.03, 0.03, 0.04, 0.05, 0.05, 0.05 }));
            absorbers.Add(new RowFloat("Кирпичная стена окрашенная", new double[] { 0.01, 0.02, 0.02, 0.02, 0.03, 0.03 }));
            absorbers.Add(new RowFloat("Бетонная стена литая неокрашенная", new double[] { 0.01, 0.02, 0.02, 0.02, 0.04, 0.04 }));
            absorbers.Add(new RowFloat("Бетонная стена окрашенная", new double[] { 0.01, 0.01, 0.02, 0.02, 0.02, 0.02 }));
            absorbers.Add(new RowFloat("Штукатурка акустическая", new double[] { 0.27, 0.31, 0.31, 0.33, 0.4, 0.4 }));
            absorbers.Add(new RowFloat("Штукатурка гипсовая", new double[] { 0.03, 0.04, 0.06, 0.06, 0.03, 0.03 }));
            absorbers.Add(new RowFloat("Штукатурка известковая", new double[] { 0.05, 0.06, 0.09, 0.04, 0.06, 0.06 }));
            absorbers.Add(new RowFloat("Штукатурка по обрешетке", new double[] { 0.02, 0.03, 0.04, 0.04, 0.04, 0.04 }));
            absorbers.Add(new RowFloat("Древесностружечная плита (20 мм) вплотную к стене", new double[] { 0.09, 0.09, 0.08, 0.09, 0.14, 0.14 }));
            absorbers.Add(new RowFloat("Древесно-стружечная плита (20 мм) на 100 мм от стены", new double[] { 0.08, 0.04, 0.02, 0.08, 0.1, 0.16 }));
            absorbers.Add(new RowFloat("Древесно-стружечная плита оклеенная пластиком на 100 мм от стены", new double[] { 0.22, 0.1, 0.08, 0.11, 0.06, 0.07 }));
            absorbers.Add(new RowFloat("Древесноволокнистые плиты (12 мм)", new double[] { 0.3, 0.34, 0.32, 0.41, 0.42, 0.42 }));
            absorbers.Add(new RowFloat("Панель гипсовая (10 мм) на 100 мм от стены", new double[] { 0.28, 0.15, 0.06, 0.05, 0.02, 0.02 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (18 мм) вплотную к стене", new double[] { 0.14, 0.65, 0.9, 0.87, 0.86, 0.92 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (18 мм) на 100 мм от стены", new double[] { 0.81, 0.86, 0.87, 0.89, 0.86, 0.88 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (10 мм) вплотную к стене", new double[] { 0.24, 0.59, 0.66, 0.66, 0.6, 0.56 }));
            absorbers.Add(new RowFloat("Плиты «Травертон» (10 мм) на 100 мм от стены", new double[] { 0.76, 0.59, 0.54, 0.62, 0.66, 0.66 }));
            absorbers.Add(new RowFloat("Плиты «Акмигран» (20 мм)  вплотную к стене", new double[] { 0.19, 0.56, 0.78, 0.82, 0.85, 0.7 }));
            absorbers.Add(new RowFloat("Плиты «Акмигран» ( 20 мм) на 100 мм от стены", new double[] { 0.7, 0.68, 0.68, 0.75, 0.74, 0.7 }));
            absorbers.Add(new RowFloat("Фанерная обшивка", new double[] { 0.11, 0.06, 0.08, 0.09, 0.12, 0.12 }));
            absorbers.Add(new RowFloat("Фанерная обшивка с обоями", new double[] { 0.1, 0.06, 0.07, 0.07, 0.07, 0.07 }));
            absorbers.Add(new RowFloat("Деревянные панели", new double[] { 0.07, 0.06, 0.06, 0.06, 0.06, 0.06 }));
            absorbers.Add(new RowFloat("Деревянная обшивка (сосна)", new double[] { 0.11, 0.1, 0.08, 0.08, 0.11, 0.11 }));
            absorbers.Add(new RowFloat("Щиты Бекеши (холст на вате толщиной 40 мм)", new double[] { 0.81, 0.73, 0.51, 0.46, 0.45, 0.45 }));
            absorbers.Add(new RowFloat("Драпировка х/б у стены", new double[] { 0.12, 0.35, 0.45, 0.38, 0.36, 0.36 }));
            absorbers.Add(new RowFloat("Драпировка х/б на 20 см от стены", new double[] { 0.29, 0.44, 0.5, 0.4, 0.35, 0.35 }));
            absorbers.Add(new RowFloat("Вентиляционная решетка", new double[] { 0.5, 0.4, 0.35, 0.3, 0.25, 0.25 }));
            absorbers.Add(new RowFloat("Пол бетонный", new double[] { 0.01, 0.02, 0.02, 0.02, 0.02, 0.02 }));
            absorbers.Add(new RowFloat("Пол деревянный", new double[] { 0.04, 0.03, 0.03, 0.03, 0.03, 0.05 }));
            absorbers.Add(new RowFloat("Пол, покрытый линолеумом", new double[] { 0.03, 0.03, 0.04, 0.04, 0.05, 0.02 }));
            absorbers.Add(new RowFloat("Пол паркетный ", new double[] { 0.04, 0.07, 0.06, 0.06, 0.07, 0.07 }));
            absorbers.Add(new RowFloat("Пол паркетный на шпонках", new double[] { 0.15, 0.12, 0.1, 0.08, 0.07, 0.06 }));
            absorbers.Add(new RowFloat("Пол деревянный, натертый мастикой", new double[] { 0.11, 0.1, 0.07, 0.06, 0.07, 0.06 }));
            absorbers.Add(new RowFloat("Метлахская плитка", new double[] { 0.01, 0.02, 0.02, 0.02, 0.03, 0.03 }));
            absorbers.Add(new RowFloat("Мрамор или плитка", new double[] { 0.01, 0.01, 0.02, 0.02, 0.01, 0.01 }));
            absorbers.Add(new RowFloat("Ковер на подкладке", new double[] { -1, 0.25, -1, 0.4, -1, -1 }));
            absorbers.Add(new RowFloat("Ковер без подкладки", new double[] { -1, 0.15, -1, 0.25, -1, -1 }));
            absorbers.Add(new RowFloat("Ковер с ворсом (10 мм) на бетоне", new double[] { 0.08, 0.21, 0.27, 0.27, 0.37, -1 }));
            absorbers.Add(new RowFloat("Ковер шерстяной с ворсом ( 8 мм)", new double[] { 0.05, 0.26, 0.47, 0.54, 0.7, 0.71 }));
            absorbers.Add(new RowFloat("Ковер капроновый ( 8 мм)", new double[] { 0.04, 0.21, 0.45, 0.55, 0.62, 0.64 }));
            absorbers.Add(new RowFloat("Дорожка ковровая безворсовая", new double[] { 0.05, 0.07, 0.11, 0.29, 0.48, 0.5 }));
            absorbers.Add(new RowFloat("Ковер-плюш", new double[] { 0.08, 0.21, 0.26, 0.27, 0.37, -1 }));
            absorbers.Add(new RowFloat("Оконное стекло ", new double[] { 0.03, 0.03, 0.02, 0.02, 0.02, 0.04 }));
            absorbers.Add(new RowFloat("Застекленные оконные переплеты", new double[] { 0.25, 0.18, 0.12, 0.07, 0.04, 0.03 }));
            absorbers.Add(new RowFloat("Занавеси легкие", new double[] { 0.08, 0.11, 0.25, 0.3, 0.3, -1 }));
            absorbers.Add(new RowFloat("Занавеси тяжелые", new double[] { 0.27, 0.5, 0.8, 0.82, 0.75, -1 }));
            absorbers.Add(new RowFloat("Занавес из тарной ткани", new double[] { 0.07, 0.19, 0.42, 0.48, 0.3, 0.44 }));
            absorbers.Add(new RowFloat("Занавес из репса", new double[] { 0.09, 0.38, 0.68, 0.66, 0.6, 0.5 }));
            absorbers.Add(new RowFloat("Занавес «Маркиза»", new double[] { 0.16, 0.29, 0.46, 0.5, 0.52, 0.55 }));
            absorbers.Add(new RowFloat("Двери лакированные", new double[] { 0.02, 0.05, 0.04, 0.04, 0.04, 0.04 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из стекловол. «Шуманет-СК», без относа", new double[] { 0.67, 1.0, 1.0, 0.99, 0.9, -1 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из стекловол. «Шуманет-СК», с относом 50 мм от стены", new double[] { 0.92, 1.0, 1.0, 0.9, 0.83, -1 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из минваты «Шуманет-БМ», без относа", new double[] { 0.67, 1.0, 1.0, 0.99, 0.9, -1 }));
            absorbers.Add(new RowFloat("Звукопоглощ. плиты из минваты «Шуманет-БМ», с относом 50 мм от стены", new double[] { 0.92, 1.0, 1.0, 0.9, 0.83, -1 }));

            foreach (RowFloat r in absorbers)
            {
                colAbsorbRatio.Items.Add(r.ToString());
            }

            cbMaterial.Items.Add(new RowFloat("Полотно остекления (2 стекла, деревянная рама)", new double[] { 41, 43, 40, 36, 32 }));
            cbMaterial.Items.Add(new RowFloat("Полотно остекления (3 стекла, стеклопакет)", new double[] { 53, 47, 49, 48, 46 }));
            cbMaterial.Items.Add(new RowFloat("Деревянная рама", new double[] { 46, 49, 44, 47, 50 }));
            cbMaterial.Items.Add(new RowFloat("Пластиковая рама", new double[] { 34, 38, 34, 33, 35 }));
            cbMaterial.Items.Add(new RowFloat("Железобетонное перекрытие (толщина 35 см)", new double[] { 34, 37, 32, 37, 35 }));
            cbMaterial.Items.Add(new RowFloat("Кирпич (толщина 1.5 кирпича)", new double[] { 50, 50, 51, 48, 42 }));
            cbMaterial.Items.Add(new RowFloat("Труба системы отопления длинной 3 м", new double[] { 44, 51, 46, 46, 41 }));
            cbMaterial.Items.Add(new RowFloat("Труба системы отопления длинной 1 м", new double[] { 36, 34, 35, 40, 31 }));
        }

        public FormVibro(CPVibro data) :this()
        {
            cbSignalLevel.SelectedIndex = data.SignalLevelIndex;

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
            tbDistance.Text = data.Distance.ToString();
            cbSignalPlace.SelectedIndex = data.SignalPlaceIndex;
            cbMaterial.SelectedIndex = data.MaterialIndex;

            tbSoundprofLevel250.Text = data.Results.SoundproofLefel[1].ToString();
            tbSoundprofLevel500.Text = data.Results.SoundproofLefel[2].ToString();
            tbSoundprofLevel1000.Text = data.Results.SoundproofLefel[3].ToString();
            tbSoundprofLevel2000.Text = data.Results.SoundproofLefel[4].ToString();
            tbSoundprofLevel4000.Text = data.Results.SoundproofLefel[5].ToString();

            tbRatio250.Text = data.Results.Ratio[1].ToString();
            tbRatio500.Text = data.Results.Ratio[2].ToString();
            tbRatio1000.Text = data.Results.Ratio[3].ToString();
            tbRatio2000.Text = data.Results.Ratio[4].ToString();
            tbRatio4000.Text = data.Results.Ratio[5].ToString();

            tbReadability.Text = data.Results.W.ToString();
        }

        private void FormVibro_Load(object sender, EventArgs e)
        {
            
        }

        private ArrayList consumers = new ArrayList();
        private ArrayList absorbers = new ArrayList();

        private void tbAbsorbersNumber_TextChanged(object sender, EventArgs e)
        {
            onTextChanged((TextBox)sender, dgvAbsorber);
        }

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
            if (Int32.TryParse(tb.Text, out n)) //Попытка распознать введенное значение
            {
                //Если значение распознано успешно
                if (0 <= n && n < 100) //Ограничение на количество компонентов
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
                    //В случае ошибки поле окрашивается в красный цвет
                    tb.BackColor = Color.Red;
                    tb.Text = "";
                }
            }
            else
            {
                //В случае ошибки поле окрашивается в красный цвет
                tb.BackColor = Color.Red;
                tb.Text = "";
            }
        }

        public int SignalLevel
        {
            get
            {
                return cbSignalLevel.SelectedIndex;
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

        public int Material
        {
            get
            {
                return cbMaterial.SelectedIndex;
            }
        }

        public int SignalPlace
        {
            get
            {
                return cbSignalPlace.SelectedIndex;
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
            tbSoundprofLevel250.Text = L(0).ToString("F1");
            tbSoundprofLevel500.Text = L(1).ToString("F1");
            tbSoundprofLevel1000.Text = L(2).ToString("F1");
            tbSoundprofLevel2000.Text = L(3).ToString("F1");
            tbSoundprofLevel4000.Text = L(4).ToString("F1");
        }

        private double updateRatio(TextBox SoundproofLevel, int freq)
        {
            double t1 = Double.Parse(SoundproofLevel.Text);
            RowFloat row = (RowFloat)cbMaterial.SelectedItem;
            double t2 = row.Values[freq];

            if (noiseReduction == NoiseReductionEnum.None)
                return t1 - t2;
            else
                return t1 - t2 + (noiseReduction == NoiseReductionEnum.Strong ? (new double[] { 7.0, 7.0, 6.0, 3.0, 1.5 })[freq] : (new double[] { 4.0, 4.0, 3.0, 1.5, 0.5 })[freq]);
        }
        private void updateRatios()
        {
            tbRatio250.Text = updateRatio(tbSoundprofLevel250, 0).ToString("F1");
            tbRatio500.Text = updateRatio(tbSoundprofLevel500, 1).ToString("F1");
            tbRatio1000.Text = updateRatio(tbSoundprofLevel1000, 2).ToString("F1");
            tbRatio2000.Text = updateRatio(tbSoundprofLevel2000, 3).ToString("F1");
            tbRatio4000.Text = updateRatio(tbSoundprofLevel4000, 4).ToString("F1");
        }

        private void updateReadability()
        {

            double[] q = new double[5];
            try
            {
                q[0] = Double.Parse(tbRatio250.Text);
                q[1] = Double.Parse(tbRatio500.Text);
                q[2] = Double.Parse(tbRatio1000.Text);
                q[3] = Double.Parse(tbRatio2000.Text);
                q[4] = Double.Parse(tbRatio4000.Text);
            }
            catch (FormatException e)
            {
                throw new Exception("Ошибка в заполнении текстового поля 'Отношение сигнал-шум'");
            }
            double[] p = new double[5];
            double R = 0;
            double[] Q = new double[5];
            for (int i = 0; i < q.Length; i++)
            {
                Q[i] = q[i] - (new double[] { 18, 14, 9, 6, 5 })[i];
                if (Q[i] <= 0)
                {
                    p[i] = (0.78 + 5.46 * Math.Exp(-4.3 * 0.001 * Math.Pow(27.3 - Math.Abs(Q[i]), 2))) / (1 + Math.Pow(10, 0.1 * Math.Abs(Q[i])));
                }
                else
                {
                    p[i] = 1 - (0.78 + 5.46 * Math.Exp(-4.3 * 0.001 * Math.Pow(27.3 - Math.Abs(Q[i]), 2))) / (1 + Math.Pow(10, 0.1 * Math.Abs(Q[i])));
                }

                R += p[i] * (new double[] { 0.03, 0.12, 0.2, 0.3, 0.26 })[i];
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
            double Lci = getLci(freq);
            double Omega = getOmega();
            double r = getR();
            double alpha = getAvp(freq) / getS();
            double k = 3.125 * alpha + 0.625;
            if (k < 1) k = 1;

            double B = getB();

            return Lci + 10 * Math.Log10(1 / (Omega * r * r) + 4 / (k * B));
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
                throw new Exception("Неправильна введена объем смежного помещения");
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
                    throw new Exception("Не выбран тип смежного помещения");
            }
            return B;
        }

        /// <summary>
        /// Получает Уровень сигнала источника
        /// </summary>
        /// <param name="freq">номер частоты</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
            catch(Exception)
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
            catch(Exception)
            {
                throw new Exception("Не правильно введено Расстояние от источника сигнала");
            }
        }

        /// <summary>
        /// Считает Эквивалентную площадь звукопоглащения поверхностей выделенного помещения
        /// </summary>
        /// <param name="freq"></param>
        /// <returns></returns>
        private double getAvp(int freq)
        {
            int M = 0;
            try
            {
                M = Int32.Parse(tbAbsorbersNumber.Text);
            }
            catch(Exception)
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

        private NoiseReductionEnum noiseReduction = NoiseReductionEnum.None;

        private enum NoiseReductionEnum
        {
            None,
            Weak,
            Strong
        }

        private void cbSignalLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Row row = (Row)cbSignalLevel.SelectedItem;
            tbSignalLevel250.Text = row.Values[0].ToString();
            tbSignalLevel500.Text = row.Values[1].ToString();
            tbSignalLevel1000.Text = row.Values[2].ToString();
            tbSignalLevel2000.Text = row.Values[3].ToString();
            tbSignalLevel4000.Text = row.Values[4].ToString();
        }

        private void rbNoNoiseReduction_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoNoiseReduction.Checked)
            {
                noiseReduction = NoiseReductionEnum.None;
            }
            else if (rbStrongNoiseReduction.Checked)
            {
                noiseReduction = NoiseReductionEnum.Strong;
            }
            else
            {
                noiseReduction = NoiseReductionEnum.Weak;
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

                    res.Ratio[1] = Double.Parse(tbRatio250.Text);
                    res.Ratio[2] = Double.Parse(tbRatio500.Text);
                    res.Ratio[3] = Double.Parse(tbRatio1000.Text);
                    res.Ratio[4] = Double.Parse(tbRatio2000.Text);
                    res.Ratio[5] = Double.Parse(tbRatio4000.Text);

                    res.SoundproofLefel[1] = Double.Parse(tbSoundprofLevel250.Text);
                    res.SoundproofLefel[2] = Double.Parse(tbSoundprofLevel500.Text);
                    res.SoundproofLefel[3] = Double.Parse(tbSoundprofLevel1000.Text);
                    res.SoundproofLefel[4] = Double.Parse(tbSoundprofLevel2000.Text);
                    res.SoundproofLefel[5] = Double.Parse(tbSoundprofLevel4000.Text);

                    Row r = (Row)cbSignalLevel.SelectedItem;
                    for (int i = 1; i < r.Values.Length; i++)
                        res.SignalLevel[i] = r.Values[i - 1];

                    res.NoiseLevel = null;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return res;
            }
        }
    }
}
