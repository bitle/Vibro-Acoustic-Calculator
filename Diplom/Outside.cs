using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diplom.Data;

namespace Diplom
{
    public partial class Outside : Form
    {
        public Outside()
        {
            InitializeComponent();
            MaximizeBox = false;

            cbSignalLevel.Items.Clear();
            cbSignalLevel.Items.Add(new Row("Тихая речь", new int[] { 47, 60, 60, 55, 50, 47, 43 }));
            cbSignalLevel.Items.Add(new Row("Речь средней громкости", new int[] { 53, 66, 66, 61, 56, 53, 49 }));
            cbSignalLevel.Items.Add(new Row("Громкая речь", new int[] { 59, 72, 72, 67, 62, 59, 55 }));
            cbSignalLevel.Items.Add(new Row("Очень громкая речь", new int[] { 67, 80, 80, 75, 70, 67, 63 }));



            cbNoiseType.Items.Clear();
            //cbNoiseType.Items.Add(new Row("Помещения офисов, раб. помещения (день)", new int[] { 57, 49, 44, 40, 37, 35, 33 }));
            //cbNoiseType.Items.Add(new Row("Тихое помещение (день)", new int[] { 48, 40, 34, 30, 27, 25, 23 }));
            //cbNoiseType.Items.Add(new Row("Тихое помещение (ночь)", new int[] { 39, 31, 24, 20, 17, 14, 13 }));
            cbNoiseType.Items.Add(new Row("Улица без движения", new int[] { 57, 49, 44, 40, 37, 35, 33 }));
            cbNoiseType.Items.Add(new Row("Улица со средней интенсивностью движения", new int[] { 66, 59, 54, 50, 47, 45, 44 }));

            //Стены
            materials.Add(new Row("Стена Кирпичная кладка в 0.5 кирпича, оштукатуренная с 2 сторон", new int[] { 39, 40, 42, 48, 54, 60, 60 }));
            materials.Add(new Row("Стена Кирпичная кладка в 1 кирпич, оштукатуренная с 2 сторон", new int[] { 41, 44, 51, 58, 64, 65, 65 }));
            materials.Add(new Row("Стена Кирпичная кладка в 1.5 кирпича, оштукатуренная с 2 сторон", new int[] { 44, 48, 55, 61, 65, 65, 65 }));
            materials.Add(new Row("Стена Кирпичная кладка в 2 кирпича, оштукатуренная с 2 сторон", new int[] { 45, 52, 59, 65, 70, 70, 70 }));
            materials.Add(new Row("Стена Кирпичная кладка в 2.5 кирпича, оштукатуренная с 2 сторон", new int[] { 47, 55, 60, 67, 70, 70, 70 }));
            materials.Add(new Row("Стена Ж/б стена, 40 мм", new int[] { 32, 36, 35, 38, 47, 53, 53 }));
            materials.Add(new Row("Стена Ж/б стена, 50 мм", new int[] { 34, 35, 35, 41, 48, 55, 55 }));
            materials.Add(new Row("Стена Ж/б стена, 100 мм", new int[] { 40, 40, 44, 50, 55, 60, 60 }));
            materials.Add(new Row("Стена Ж/б стена, 160 мм", new int[] { 43, 47, 51, 60, 63, 60, 60 }));
            materials.Add(new Row("Стена Ж/б стена, 200 мм", new int[] { 42, 44, 51, 59, 65, 65, 65 }));
            materials.Add(new Row("Стена Ж/б стена, 300 мм", new int[] { 45, 50, 58, 65, 69, 69, 69 }));
            materials.Add(new Row("Стена Ж/б стена, 400 мм", new int[] { 48, 55, 61, 68, 70, 70, 70 }));
            materials.Add(new Row("Стена Ж/б стена, 800 мм", new int[] { 55, 61, 68, 70, 70, 70, 70 }));
            materials.Add(new Row("Стена Гипсокартонная плита, 80 мм", new int[] { 28, 33, 37, 39, 44, 44, 42 }));
            materials.Add(new Row("Стена Гипсокартонная плита, 120 мм", new int[] { 32, 37, 37, 42, 48, 53, 42 }));
            materials.Add(new Row("Стена Керамзитобетонная плита, 80 мм", new int[] { 33, 34, 39, 47, 52, 54, 42 }));
            materials.Add(new Row("Стена Керамзитобетонная плита, 120 мм", new int[] { 33, 37, 39, 47, 52, 54, 42 }));
            materials.Add(new Row("Стена Газобетонная плита, 240 мм", new int[] { 39, 42, 51, 56, 54, 62, 60 }));
            materials.Add(new Row("Стена Пенобетонная панель, 130 мм, оштукатуренная с 2 сторон", new int[] { 37, 34, 46, 50, 60, 65, 60 }));
            materials.Add(new Row("Стена Шлакобетонная панель, 250 мм", new int[] { 30, 45, 50, 59, 64, 64, 60 }));
            materials.Add(new Row("Стена Шлакобетонная панель, 140 мм", new int[] { 30, 41, 45, 49, 51, 51, 51 }));
            materials.Add(new Row("Стена Шлакоблоки, 220 мм, оштукатуренные с 2 сторон", new int[] { 42, 42, 48, 54, 60, 63, 63 }));
            materials.Add(new Row("Стена Армированная силикатобетонная панель, 140 мм", new int[] { 34, 41, 48, 55, 59, 59, 63 }));
            materials.Add(new Row("Стена Древесностружечная плита, 20 мм", new int[] { 23, 26, 26, 25, 26, 28 }));
            materials.Add(new Row("Стена Фанера, 3 мм", new int[] { 11, 14, 19, 23, 26, 27, 26 }));
            materials.Add(new Row("Стена Фанера, 4 мм", new int[] { 12, 16, 20, 24, 27, 27, 27 }));
            materials.Add(new Row("Стена Фанера, 5 мм", new int[] { 13, 17, 21, 25, 28, 26, 29 }));
            materials.Add(new Row("Стена Фанера, 8 мм", new int[] { 16, 20, 24, 27, 27, 27, 32 }));
            materials.Add(new Row("Стена Фанера, 10 мм", new int[] { 17, 24, 25, 28, 25, 29, 33 }));

            //Перекрытия
            materials.Add(new Row("Перекрытие Ж/б панель, 140 мм", new int[] { 40, 47, 52, 56, 61, 61, 61 }));
            materials.Add(new Row("Перекрытие Ж/б панель, 140 мм, с полами на войлочной подоснове", new int[] { 35, 38, 47, 55, 65, 62, 62 }));
            materials.Add(new Row("Перекрытие Ж/б панель, покрытая линолеумом на тканевой основе", new int[] { 37, 42, 50, 57, 52, 60, 60 }));
            materials.Add(new Row("Перекрытие Паркетные доски", new int[] { 37, 43, 52, 62, 67, 63, 63 }));

            // Двери
            materials.Add(new Row("Дверь Обыкновенная филенчатая, с уплотнительными прокладками", new int[] { 18, 19, 23, 30, 33, 32, 32 }));
            materials.Add(new Row("Дверь Обыкновенная филенчатая, без уплотнительных прокладок", new int[] { 12, 14, 16, 22, 22, 20, 20 }));
            materials.Add(new Row("Дверь Глухая щитовая, облицованная фанерой толщиной 4 мм, без уплотнительных прокладок", new int[] { 22, 23, 24, 24, 24, 23, 23 }));
            materials.Add(new Row("Дверь Глухая щитовая, облицованная фанерой толщиной 4 мм, с уплотнительными прокладками", new int[] { 27, 27, 32, 35, 34, 35, 35 }));
            materials.Add(new Row("Дверь Типовая, без уплотнительных прокладок", new int[] { 13, 23, 31, 33, 34, 36, 44 }));
            materials.Add(new Row("Дверь Типовая, с уплотнительными прокладками", new int[] { 29, 30, 33, 35, 39, 41, 42 }));
            materials.Add(new Row("Дверь Щитовая, заполненная стекловатой, без уплотнительных прокладок", new int[] { 25, 26, 30, 31, 28, 29, 29 }));
            materials.Add(new Row("Дверь Щитовая, заполненная стекловатой, с уплотнительными прокладками", new int[] { 28, 30, 33, 36, 32, 30, 30 }));
            materials.Add(new Row("Дверь Щитовая, заполненная минеральным волокном, без уплотнительных прокладок", new int[] { 24, 24, 28, 27, 25, 24, 24 }));
            materials.Add(new Row("Дверь Щитовая, заполненная минеральным волокном, с уплотнительными прокладками", new int[] { 28, 28, 32, 34, 32, 32, 32 }));
            materials.Add(new Row("Дверь Звукоизолирующая, легкая", new int[] { 18, 30, 39, 42, 45, 42, 45 }));
            materials.Add(new Row("Дверь Звукоизолирующая, легкая, двойная (зазор > 200 мм)", new int[] { 25, 42, 55, 58, 60, 60, 60 }));
            materials.Add(new Row("Дверь Звукоизолирующая, тяжелая", new int[] { 24, 36, 45, 51, 50, 49, 56 }));
            materials.Add(new Row("Дверь Звукоизолирующая, тяжелая, двойная (зазор > 300 мм)", new int[] { 34, 46, 60, 65, 65, 65, 65 }));
            materials.Add(new Row("Дверь Звукоизолирующая, тяжелая, двойная (зазор > 300 мм), с облицовкой тамбура", new int[] { 45, 58, 65, 70, 70, 70, 70 }));

            //Окна
            materials.Add(new Row("Окно Открытое", new int[] { 0, 0, 0, 0, 0, 0, 0 }));
            materials.Add(new Row("Окно С силикатным стеклом, толщина 3 мм", new int[] { 12, 16, 18, 20, 22, 20, 20 }));
            materials.Add(new Row("Окно С силикатным стеклом, толщина 6 мм", new int[] { 18, 18, 20, 23, 25, 25, 25 }));
            materials.Add(new Row("Окно Блок с двойным переплетом (зазор > 170 мм), толщина стекла 3 мм, без прокладок", new int[] { 27, 26, 28, 30, 28, 27, 27 }));
            materials.Add(new Row("Окно Блок с двойным переплетом (зазор > 170 мм), толщина стекла 3 мм, с прокладками", new int[] { 33, 33, 36, 38, 38, 38, 38 }));
            materials.Add(new Row("Окно Двойное остекленение со стеклами 4 и 7 мм (зазор 200 мм)", new int[] { 27, 36, 41, 47, 49, 55, 55 }));
            materials.Add(new Row("Окно Двойное остекленение со стеклами 4 и 7 мм (зазор 300 мм)", new int[] { 32, 39, 43, 47, 51, 55, 55 }));
            materials.Add(new Row("Окно Стеклопакет, толщина 98 мм, с уплотнительными прокладками", new int[] { 37, 40, 42, 45, 48, 50, 50 }));
            materials.Add(new Row("Окно С органическим стеклом (1х1.2), толщина 4 мм, с герметизацией притвора", new int[] { 17, 21, 25, 29, 33, 36, 30 }));
            materials.Add(new Row("Окно С органическим стеклом (1х1.2), толщина 10 мм, с герметизацией притвора", new int[] { 23, 26, 31, 34, 34, 32, 40 }));
            materials.Add(new Row("Окно С органическим стеклом (1х1.2), толщина 18 мм, с герметизацией притвора", new int[] { 30, 32, 35, 35, 33, 38, 45 }));
            materials.Add(new Row("Окно С органическим стеклом (1х1.2), толщина 36 мм, с герметизацией притвора", new int[] { 35, 34, 35, 40, 40, 48, 48 }));
            materials.Add(new Row("Окно С силикатным стеклом, толщина 4 мм, с герметизацией притвора", new int[] { 19, 24, 28, 30, 33, 31, 31 }));
            materials.Add(new Row("Окно С силикатным стеклом, толщина 7 мм, с герметизацией притвора", new int[] { 22, 28, 29, 34, 28, 39, 39 }));
            materials.Add(new Row("Окно Витраж с открывающимися створками, силикатное стекло, толщина 7 мм", new int[] { 22, 27, 29, 31, 25, 36, 36 }));

            foreach (Row r in materials)
            {
                colReflectMaterial.Items.Add(r.ToString());
            }

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
            absorbers.Add(new RowFloat("Ковер на подкладке", new double[] { 0.1, 0.2, 0.25, -1, 0.4, 0.4, 0.4 }));
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

            //cbSignalSource.Items.Clear();
            //cbSignalSource.Items.Add(new Row("64 дБ", new int[] { 47, 60, 60, 55, 50, 47, 43 }));
            //cbSignalSource.Items.Add(new Row("70 дБ", new int[] { 53, 66, 66, 61, 56, 53, 49 }));
            //cbSignalSource.Items.Add(new Row("76 дБ", new int[] { 59, 72, 72, 67, 62, 59, 55 }));
            //cbSignalSource.Items.Add(new Row("84 дБ", new int[] { 67, 80, 80, 75, 70, 67, 63 }));


            cbFading.Items.Clear();
            cbFading.Items.Add(new RowFloat("-20 град., 70%", new double[] { 0.514, 1.73, 5.29, 11.5, 16.6, 20.2, 27.8 }));
            cbFading.Items.Add(new RowFloat("-10 град., 70%", new double[] { 0.332, 0.826, 2.65, 9.19, 27.8, 58.5, 86.2 }));
            cbFading.Items.Add(new RowFloat("0 град., 70%", new double[] { 0.339, 0.763, 1.61, 4.64, 16.1, 55.5, 153 }));
            cbFading.Items.Add(new RowFloat("10 град., 70 %", new double[] { 0.411, 1.04, 1.93, 3.66, 9.66, 32.8, 117 }));
            cbFading.Items.Add(new RowFloat("20 град., 70 %", new double[] { 0.339, 1.13, 2.8, 4.98, 9.02, 22.9, 76.6 }));
            cbFading.Items.Add(new RowFloat("30 град., 70%", new double[] { 0.256, 0.963, 3.14, 7.41, 12.7, 23.1, 59.3 }));

            cbFading.Items.Add(new RowFloat("20 град., 30%", new double[] { 0.615, 1.42, 2.52, 5.01, 14.1, 48.5, 166 }));
            cbFading.Items.Add(new RowFloat("20 град., 40%", new double[] { 0.521, 1.39, 2.63, 4.65, 11.2, 36.1, 128 }));
            cbFading.Items.Add(new RowFloat("20 град., 50%", new double[] { 0.445, 1.32, 2.73, 4.66, 9.86, 29.4, 104 }));
            cbFading.Items.Add(new RowFloat("20 град., 60%", new double[] { 0.386, 1.23, 2.79, 4.80, 9.25, 25.4, 87.8 }));
            cbFading.Items.Add(new RowFloat("20 град., 70%", new double[] { 0.339, 1.13, 2.80, 4.98, 9.02, 22.9, 76.6 }));
            cbFading.Items.Add(new RowFloat("20 град., 80%", new double[] { 0.302, 1.04, 2.77, 5.15, 8.98, 21.3, 68.6 }));
            cbFading.Items.Add(new RowFloat("20 град., 90%", new double[] { 0.272, 0.966, 2.71, 5.30, 9.06, 20.2, 62.6 }));
            cbFading.Items.Add(new RowFloat("20 град., 100%", new double[] { 0.274, 0.895, 2.63, 5.42, 9.21, 19.4, 59.1 }));
        }
        public Outside(CPOutside data) :this()
        {
            cbSignalLevel.SelectedIndex = data.SignalLevelIndex;
            cbNoiseType.SelectedIndex = data.NoiseTypeIndex;
            
            tbReflectorsNumber.Text = data.reflectorsList.Count.ToString();
            dgvReflectors.Rows.Clear();
            foreach (CPOutside.Reflector r in data.reflectorsList)
            {
                int new_row = dgvReflectors.Rows.Add();
                //int new_row = dgvReflectors.Rows.Count;
                
                dgvReflectors.Rows[new_row].Cells[0].Value = r.square.ToString();
                dgvReflectors.Rows[new_row].Cells[1].Value = ((DataGridViewComboBoxCell)dgvReflectors.Rows[new_row].Cells[1]).Items[r.MaterialIndex];
            }

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
            cbFading.SelectedIndex = data.SoundFadingIndex;
            cbAngle.SelectedIndex = data.AngleIndex;

            switch (data.NoiseReduction)
            {
                case 0:
                    rbNoNoiseReduction.Checked = true;
                    break;
                case 1:
                    rbStrongNoiseReduction.Checked = true;
                    break;
                case 2:
                    rbWeakNoiseReduction.Checked = true;
                    break;
            }

            switch (data.Microphone)
            {
                case 0:
                    rbNoMicrofon.Checked = true;
                    break;
                case 1:
                    rbParabolMicrofon.Checked = true;
                    tbMicLength.Text = data.MicrophoneText.ToString();
                    break;
                case 2:
                    rbTrubchatiyMicrofon.Checked = true;
                    tbMicLength.Text = data.MicrophoneText.ToString();
                    break;
            }

            tbSoundprofLevel125.Text  = data.Results.SoundproofLefel[0].ToString();
            tbSoundprofLevel250.Text  = data.Results.SoundproofLefel[1].ToString();
            tbSoundprofLevel500.Text  = data.Results.SoundproofLefel[2].ToString();
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

        private void cbBarrierType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbBarrierType.SelectedIndex != -1)
                cbBarrierSubtype.Enabled = true;
            else
                cbBarrierSubtype.Enabled = false;
            string type = (string)cbBarrierType.SelectedItem;
            object[] list = null;
            switch (type)
            {
                case "Дверь":
                    list = ArrayListToObjectArray(subtypeDoors);
                    break;
                case "Окно":
                    list = ArrayListToObjectArray(subtypeWindows);
                    break;
                case "Перекрытие":
                    list = ArrayListToObjectArray(subtypeBarriers);
                    break;
                case "Стена":
                    list = ArrayListToObjectArray(subtypeWalls);
                    break;
                default:
                    break;
            }

            cbBarrierSubtype.Items.Clear();
            cbBarrierSubtype.Items.AddRange(list);*/
        }

        private object[] ArrayListToObjectArray(ArrayList items)
        {
            object[] list = new object[items.Count];
            int i = 0;
            foreach (object s in items)
            {
                list[i++] = s;
            }
            return list;
        }

        //private void FillUpDoor()
        //{
            
        //    subtypeDoors.Add(new Row("Обыкновенная филенчатая, с уплотнительными прокладками", new int[] {18,19,23,30,33,32,32}));
        //    subtypeDoors.Add(new Row("Обыкновенная филенчатая, без уплотнительных прокладок", new int[] {12,14,16,22,22,20,20}));
        //    subtypeDoors.Add(new Row("Глухая щитовая, облицованная фанерой толщиной 4 мм, без уплотнительных прокладок", new int[] {22,23,24,24,24,23,23}));
        //    subtypeDoors.Add(new Row("Глухая щитовая, облицованная фанерой толщиной 4 мм, с уплотнительными прокладками", new int[] {27,27,32,35,34,35,35}));
        //    subtypeDoors.Add(new Row("Типовая, без уплотнительных прокладок", new int[] {13,23,31,33,34,36,44}));
        //    subtypeDoors.Add(new Row("Типовая, с уплотнительными прокладками", new int[] {29,30,33,35,39,41,42}));
        //    subtypeDoors.Add(new Row("Щитовая, заполненная стекловатой, без уплотнительных прокладок", new int[] {25,26,30,31,28,29,29}));
        //    subtypeDoors.Add(new Row("Щитовая, заполненная стекловатой, с уплотнительными прокладками", new int[] {28,30,33,36,32,30,30}));
        //    subtypeDoors.Add(new Row("Щитовая, заполненная минеральным волокном, без уплотнительных прокладок", new int[] {24,24,28,27,25,24,24}));
        //    subtypeDoors.Add(new Row("Щитовая, заполненная минеральным волокном, с уплотнительными прокладками", new int[] {28,28,32,34,32,32,32}));
        //    subtypeDoors.Add(new Row("Звукоизолирующая, легкая", new int[] {18,30,39,42,45,42,45}));
        //    subtypeDoors.Add(new Row("Звукоизолирующая, легкая, двойная (зазор > 200 мм)", new int[] {25,42,55,58,60,60,60}));
        //    subtypeDoors.Add(new Row("Звукоизолирующая, тяжелая", new int[] {24,36,45,51,50,49,56}));
        //    subtypeDoors.Add(new Row("Звукоизолирующая, тяжелая, двойная (зазор > 300 мм)", new int[] {34,46,60,65,65,65,65}));
        //    subtypeDoors.Add(new Row("Звукоизолирующая, тяжелая, двойная (зазор > 300 мм), с облицовкой тамбура", new int[] {45,58,65,70,70,70,70}));
        //}

        //private void FillUpWindows()
        //{
            
        //    subtypeWindows.Add(new Row("С силикатным стеклом, толщина 3 мм", new int[] {12,16,18,20,22,20,20}));
        //    subtypeWindows.Add(new Row("С силикатным стеклом, толщина 6 мм", new int[] {18,18,20,23,25,25,25}));
        //    subtypeWindows.Add(new Row("Блок с двойным переплетом (зазор > 170 мм), толщина стекла 3 мм, без прокладок", new int[] {27,26,28,30,28,27,27}));
        //    subtypeWindows.Add(new Row("Блок с двойным переплетом (зазор > 170 мм), толщина стекла 3 мм, с прокладками", new int[] {33,33,36,38,38,38,38}));
        //    subtypeWindows.Add(new Row("Двойное остекленение со стеклами 4 и 7 мм (зазор 200 мм)", new int[] {27,36,41,47,49,55,55}));
        //    subtypeWindows.Add(new Row("Двойное остекленение со стеклами 4 и 7 мм (зазор 300 мм)", new int[] {32,39,43,47,51,55,55}));
        //    subtypeWindows.Add(new Row("Стеклопакет, толщина 98 мм, с уплотнительными прокладками", new int[] {37,40,42,45,48,50,50}));
        //    subtypeWindows.Add(new Row("С органическим стеклом (1х1.2), толщина 4 мм, с герметизацией притвора", new int[] {17,21,25,29,33,36,30}));
        //    subtypeWindows.Add(new Row("С органическим стеклом (1х1.2), толщина 10 мм, с герметизацией притвора", new int[] {23,26,31,34,34,32,40}));
        //    subtypeWindows.Add(new Row("С органическим стеклом (1х1.2), толщина 18 мм, с герметизацией притвора", new int[] {30,32,35,35,33,38,45}));
        //    subtypeWindows.Add(new Row("С органическим стеклом (1х1.2), толщина 36 мм, с герметизацией притвора", new int[] {35,34,35,40,40,48,48}));
        //    subtypeWindows.Add(new Row("С силикатным стеклом, толщина 4 мм, с герметизацией притвора", new int[] {19,24,28,30,33,31,31}));
        //    subtypeWindows.Add(new Row("С силикатным стеклом, толщина 7 мм, с герметизацией притвора", new int[] {22,28,29,34,28,39,39}));
        //    subtypeWindows.Add(new Row("Витраж с открывающимися створками, силикатное стекло, толщина 7 мм", new int[] {22,27,29,31,25,36,36}));
        //}

        //private void FillUpBarriers()
        //{
            
        //    subtypeBarriers.Add(new Row("Ж/б панель, 140 мм", new int[] {40,47,52,56,61,61,61}));
        //    subtypeBarriers.Add(new Row("Ж/б панель, 140 мм, с полами на войлочной подоснове", new int[] {35,38,47,55,65,62,62}));
        //    subtypeBarriers.Add(new Row("Ж/б панель, покрытая линолеумом на тканевой основе", new int[] {37,42,50,57,52,60,60}));
        //    subtypeBarriers.Add(new Row("Паркетные доски", new int[] {37,43,52,62,67,63,63}));
        //}

        //private void FillUpWalls()
        //{
            
        //    subtypeWalls.Add(new Row("Кирпичная кладка в 0.5 кирпича, оштукатуренная с 2 сторон", new int[] {39, 40, 42, 48, 54, 60, 60}));
        //    subtypeWalls.Add(new Row("Кирпичная кладка в 1 кирпич, оштукатуренная с 2 сторон", new int[] { 41,44,51,58,64,65,65}));
        //    subtypeWalls.Add(new Row("Кирпичная кладка в 1.5 кирпича, оштукатуренная с 2 сторон", new int[] { 44,48,55,61,65,65,65}));
        //    subtypeWalls.Add(new Row("Кирпичная кладка в 2 кирпича, оштукатуренная с 2 сторон", new int[] {45,52,59,65,70,70,70}));
        //    subtypeWalls.Add(new Row("Кирпичная кладка в 2.5 кирпича, оштукатуренная с 2 сторон", new int[] {47,55,60,67,70,70,70}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 40 мм", new int[] {32,36,35,38,47,53,53}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 50 мм", new int[] {34,35,35,41,48,55,55}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 100 мм", new int[] {40,40,44,50,55,60,60}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 160 мм", new int[] {43,47,51,60,63,60,60}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 200 мм", new int[] {42,44,51,59,65,65,65}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 300 мм", new int[] {45,50,58,65,69,69,69}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 400 мм", new int[] {48,55,61,68,70,70,70}));
        //    subtypeWalls.Add(new Row("Ж/б стена, 800 мм", new int[] {55,61,68,70,70,70,70}));
        //    subtypeWalls.Add(new Row("Гипсокартонная плита, 80 мм", new int[] {28,33,37,39,44,44,42}));
        //    subtypeWalls.Add(new Row("Гипсокартонная плита, 120 мм", new int[] {32,37,37,42,48,53,42}));
        //    subtypeWalls.Add(new Row("Керамзитобетонная плита, 80 мм", new int[] {33,34,39,47,52,54,42}));
        //    subtypeWalls.Add(new Row("Керамзитобетонная плита, 120 мм", new int[] {33,37,39,47,52,54,42}));
        //    subtypeWalls.Add(new Row("Газобетонная плита, 240 мм", new int[] {39,42,51,56,54,62,60}));
        //    subtypeWalls.Add(new Row("Пенобетонная панель, 130 мм, оштукатуренная с 2 сторон", new int[] {37,34,46,50,60,65,60}));
        //    subtypeWalls.Add(new Row("Шлакобетонная панель, 250 мм", new int[] {30,45,50,59,64,64,60}));
        //    subtypeWalls.Add(new Row("Шлакобетонная панель, 140 мм", new int[] {30,41,45,49,51,51,51}));
        //    subtypeWalls.Add(new Row("Шлакоблоки, 220 мм, оштукатуренные с 2 сторон", new int[] {42,42,48,54,60,63,63}));
        //    subtypeWalls.Add(new Row("Армированная силикатобетонная панель, 140 мм", new int[] {34,41,48,55,59,59,63}));
        //    subtypeWalls.Add(new Row("Древесностружечная плита, 20 мм", new int[] {23,26,26,25,26,28}));
        //    subtypeWalls.Add(new Row("Фанера, 3 мм", new int[] {11,14,19,23,26,27,26}));
        //    subtypeWalls.Add(new Row("Фанера, 4 мм", new int[] {12,16,20,24,27,27,27}));
        //    subtypeWalls.Add(new Row("Фанера, 5 мм", new int[] {13,17,21,25,28,26,29}));
        //    subtypeWalls.Add(new Row("Фанера, 8 мм", new int[] {16,20,24,27,27,27,32}));
        //    subtypeWalls.Add(new Row("Фанера, 10 мм", new int[] {17,24,25,28,25,29,33}));

        //}
        //private ArrayList subtypeWalls = new ArrayList();
        //private ArrayList subtypeBarriers = new ArrayList();
        //private ArrayList subtypeWindows = new ArrayList();
        //private ArrayList subtypeDoors = new ArrayList();
        private ArrayList materials = new ArrayList();
        private ArrayList absorbers = new ArrayList();
        private ArrayList consumers = new ArrayList();

        private void Outside_Load(object sender, EventArgs e)
        {
            

        }

        private double L(int freq)
        {
            //L источника
            int L_ist;
            Console.WriteLine("Частота: " + freq.ToString());
            try
            {
                L_ist = ((Row)cbSignalLevel.SelectedItem).Values[freq];
            }
            catch (Exception)
            {
                MessageBox.Show("Введите Уровень сигнала источника");
                throw new Exception();
            }
            double Sz = 0;
            double Szt = 0;
            int N;
            try
            {
                N = Int32.Parse(tbReflectorsNumber.Text);
            }
            catch (Exception)
            {
                tbReflectorsNumber.BackColor = Color.Red;
                throw new Exception();
            }
            for (int i = 0; i < N; i++)
            {
                try
                {
                    Sz += Double.Parse(dgvReflectors.Rows[i].Cells[0].Value.ToString());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неправильно введена площадь");
                    throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при заполнении Описания составных частей ограждающей конструкции");
                    throw new Exception();
                }
            }
            Console.WriteLine("Sz огр. вся. = " + Sz.ToString());

            for (int i = 0; i < N; i++)
            {
                string s = (string)dgvReflectors.Rows[i].Cells[1].Value;
                Row r = searchFor2(s, materials);
                int z = r.Values[freq];
                try
                {
                    Szt += Double.Parse(dgvReflectors.Rows[i].Cells[0].Value.ToString()) / (Math.Pow(10, 0.1 * z));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неправильно введена площадь");
                    throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при заполнении Описания составных частей ограждающей конструкции");
                    throw new Exception();
                }
            }
            Console.WriteLine("Sz знаменатель = " + Szt.ToString());

            double B1000;
            try
            {
                B1000 = Double.Parse(tbNeighborVolume.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильна введена площадь выделенного помещения");
                throw new Exception();
            }
            switch (cbRoomType.SelectedIndex)
            {
                case 0:
                case 1:
                    B1000 *= 0.1;
                    B1000 += 2;
                    break;
                case 2:
                    B1000 *= 0.17;
                    B1000 += 3.3;
                    break;
                case 3:
                    B1000 *= 0.64;
                    B1000 += 1.6;
                    break;
                default:
                    MessageBox.Show("Не выбран тип выделенного помещения");
                    throw new Exception();
            }
            Console.WriteLine("B1000 = " + B1000.ToString());

            double mu = 0;
            if (Double.Parse(tbNeighborVolume.Text) < 200)
            {
                mu = (new double[] { 0.75, 0.7, 0.8, 1, 1.4, 1.8, 2.5 })[freq];
            }
            else if (200 <= Double.Parse(tbNeighborVolume.Text) && Double.Parse(tbNeighborVolume.Text) <= 1000)
            {
                mu = (new double[] { 0.62, 0.64, 0.75, 1, 1.5, 2.4, 4.2 })[freq];
            }
            else
            {
                mu = (new double[] { 0.5, 0.55, 0.7, 1, 1.6, 3.0, 6.0 })[freq];
            }
            Console.WriteLine("mu = " + mu.ToString());

            double Spr = 0;
            int M;
            try
            {
                M = Int32.Parse(tbAbsorbersNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильно введено Количество звукопоглащающих поверхностей");
                throw new Exception();
            }

            try
            {
                for (int i = 0; i < M; i++)
                {
                    Spr += Double.Parse(dgvAbsorber.Rows[i].Cells[0].Value.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильно введена Площадь звукопоглащающей поверхности");
                throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введен Коэффициент звукопоглащения поверхности");
                throw new Exception();
            }
            Console.WriteLine("S пр. сп.вся = " + Spr.ToString());

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
                MessageBox.Show("Неправильно введена Площадь звукопоглащающей поверхности");
                throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введен Коэффициент звукопоглащения поверхности");
                throw new Exception();
            }
            

            int L;
            try
            {
                L = Int32.Parse(tbConsumersNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введено Количество штучных поглотителей");
                throw new Exception();
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
                MessageBox.Show("Неправильно введена Эквивалентная площадь звукопоглащения поглотителя");
                throw new Exception();
            }
            Console.WriteLine("А сп = " + Asp.ToString());

            double distance = 0;
            try
            {
                distance = Double.Parse(tbDistance.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не правильно введено Расстояние до стены");
                throw new Exception();
            }

            double betta = 0;
            try
            {
                RowFloat r = (RowFloat)cbFading.SelectedItem;
                betta = r.Values[freq];
            }
            catch (Exception)
            {
                MessageBox.Show("Не правильно введено Затухание звука в атмосфере");
                throw new Exception();
            }

            double PHI = 0;
            if (cbAngle.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран угол");
                throw new Exception();
            }
            else if (cbAngle.SelectedIndex == 0)
            {
                PHI = -5;
            }
            else
            {
                PHI = 0;
            }

            Console.WriteLine("Lc = " + L_ist.ToString());
            Console.WriteLine("Z1000 = " + (10 * Math.Log10(Sz / Szt)).ToString());
            Console.WriteLine("Sог = " + Sz.ToString());
            Console.WriteLine("10LgSог = " + (10 * Math.Log10(Sz)).ToString());
            Console.WriteLine("Bвп1000 = " + (B1000*mu));
            Console.WriteLine("10LgBвп1000 = " + (10 * Math.Log10(B1000 * mu)));
            Console.WriteLine("kвп1000 = " + (3.125 * (Asp / Spr) + 0.625));
            Console.WriteLine("10Lg kвп1000 = " + (10 * Math.Log10(3.125 * (Asp / Spr) + 0.625)));
            Console.WriteLine("20Lg(r) = " + (20 * Math.Log10(distance)));
            Console.WriteLine("Betta = " + betta);
            Console.WriteLine("Betta * r * 10^-3 = " + (betta * distance * 0.001));
            Console.WriteLine("10Lg(2pi) = " + (10 * Math.Log10(2 * Math.PI)));
            Console.WriteLine("10Lg(PHI) = " + PHI);

            double k = 3.125 * (Asp / Spr) + 0.625;
            if (k < 1) k = 1;
            double result = L_ist - 10 * Math.Log10(Sz / Szt) + 10 * Math.Log10(Sz) - 10 * Math.Log10(B1000 * mu) - 10 * Math.Log10(k) - 20 * Math.Log10(distance) - betta * distance * 0.001 - 10 * Math.Log10(2 * Math.PI) + PHI;
            Console.WriteLine("Result: " + result);
            return result;
            //return L_ist - 10 * Math.Log10(Sz / Szt) + 10 * Math.Log10(Sz) - 10 * Math.Log10(B1000 * mu) - 10 * Math.Log10(3.125 * (Asp / Spr) + 0.625) - 20*Math.Log10(distance) - betta*distance*0.001 - 10*Math.Log10(2*Math.PI) + PHI;
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

        private Row searchFor2(string s, ArrayList list)
        {
            foreach (Row r in list)
            {
                if (r.Name.Equals(s))
                {
                    return r;
                }
            }
            return null;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                updateSignalLevelKT();
                updateRatios();
                updateReadability();
            }
            catch (Exception)
            {
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

            double res = 0;

            if (noiseReduction == NoiseReductionEnum.None)
                res = t1 - t2;
            else
                res = t1 - t2 + (noiseReduction == NoiseReductionEnum.Strong ? (new double[] { 2.5, 7.0, 7.0, 6.0, 3.0, 1.5, 0.5 })[freq] : (new double[] { 1.5, 4.0, 4.0, 3.0, 1.5, 0.5, 0.2 })[freq]);

            int[] freqs = new int[]{125, 250, 500, 1000, 2000, 4000, 8000};
            if (microfon == Microfon.Parabol)
            {
                double S;
                try
                {
                    S = Double.Parse(tbMicLength.Text);
                }
                catch
                {
                    throw new Exception("Не правильно задана площадь отражения микрофона");
                }
                res += 10 * Math.Log10(1.2 * 0.0001 * S * freqs[freq] * freqs[freq]);
            }
            else if (microfon == Microfon.Tube)
            {
                double l;
                try
                {
                    l = Double.Parse(tbMicLength.Text);
                }
                catch
                {
                    throw new Exception("Не правильно задана площадь отражения микрофона");
                }
                res += 10 * Math.Log10(6.1 * 0.001 * l * freqs[freq]);
            }

            return res;
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

        private void btnAddMicrophone_Click(object sender, EventArgs e)
        {
            FormAddMicrophone addMicrophone = new FormAddMicrophone();
            switch (addMicrophone.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    MessageBox.Show("Name: " + addMicrophone.MicrophoneName);
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    MessageBox.Show("Form Canceled");
                    break;
            }
        }

        private void cbSignalSource_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tbReflectorsNumber_TextChanged(object sender, EventArgs e)
        {
            onTextChanged((TextBox)sender, dgvReflectors);
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

        private void tbAbsorbersNumber_TextChanged(object sender, EventArgs e)
        {
            onTextChanged((TextBox)sender, dgvAbsorber);
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

        private NoiseReductionEnum noiseReduction = NoiseReductionEnum.None;

        private enum NoiseReductionEnum
        {
            None,
            Weak,
            Strong
        }

        private void rbNoMicrofon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoMicrofon.Checked)
            {
                microfon = Microfon.None;
                tbMicLength.Visible = false;
                lblMicrofon.Visible = false;
            }
            else if (rbParabolMicrofon.Checked)
            {
                microfon = Microfon.Parabol;
                tbMicLength.Visible = true;
                lblMicrofon.Visible = true;
                lblMicrofon.Text = "Площадь отражателя, м^2";
            }
            else
            {
                microfon = Microfon.Tube;
                tbMicLength.Visible = true;
                lblMicrofon.Visible = true;
                lblMicrofon.Text = "Длина трубки, м";
            }
        }

        private Microfon microfon = Microfon.None;

        private enum Microfon
        {
            None,
            Parabol,
            Tube
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
                    return 0.0;
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
                catch
                {
                    return 0.0;
                }
            }
        }

        public int SoundFading
        {
            get
            {
                return cbFading.SelectedIndex;
            }
        }

        public int Angle
        {
            get
            {
                return cbAngle.SelectedIndex;
            }
        }

        public int NoiseReduction
        {
            get
            {
                if (rbNoNoiseReduction.Checked)
                    return 0;
                else if (rbStrongNoiseReduction.Checked)
                    return 1;
                else if (rbWeakNoiseReduction.Checked)
                    return 2;
                return 0;
            }
        }

        public int Microphone
        {
            get
            {
                if (rbNoMicrofon.Checked)
                    return 0;
                else if (rbParabolMicrofon.Checked)
                    return 1;
                else if (rbTrubchatiyMicrofon.Checked)
                    return 2;
                return 0;
            }
        }

        public double MicrophoneValue
        {
            get
            {
                try
                {
                    return Double.Parse(tbMicLength.Text);
                }
                catch (FormatException)
                {
                    return 0;
                }
            }
        }

        public ArrayList Reflectors
        {
            get
            {
                ArrayList ret = new ArrayList();
                try
                {
                    foreach (DataGridViewRow dgvr in dgvReflectors.Rows)
                    {
                        CPOutside.Reflector refl = new CPOutside.Reflector();
                        refl.square = Double.Parse(dgvr.Cells[0].Value.ToString());
                        refl.MaterialIndex = ((DataGridViewComboBoxCell)dgvr.Cells[1]).Items.IndexOf(dgvr.Cells[1].Value);
                        ret.Add(refl);
                    }
                }
                catch
                {
                    ret.Clear();
                    return ret;
                }
                return ret;
            }
        }

        public ArrayList Absorbers
        {
            get
            {
                ArrayList ret = new ArrayList();
                try
                {
                    foreach (DataGridViewRow dgvr in dgvAbsorber.Rows)
                    {
                        CPOutside.Reflector refl = new CPOutside.Reflector();
                        refl.square = Double.Parse(dgvr.Cells[0].Value.ToString());
                        refl.MaterialIndex = ((DataGridViewComboBoxCell)dgvr.Cells[1]).Items.IndexOf(dgvr.Cells[1].Value);
                        ret.Add(refl);
                    }
                }
                catch
                {
                    ret.Clear();
                    return ret;
                }
                return ret;
            }
        }

        public ArrayList Consumers
        {
            get
            {
                ArrayList ret = new ArrayList();
                try
                {
                    foreach (DataGridViewRow dgvr in dgvConsumers.Rows)
                    {
                        int t = ((DataGridViewComboBoxCell)dgvr.Cells[0]).Items.IndexOf(dgvr.Cells[0].Value);
                        ret.Add(t);
                    }
                }
                catch
                {
                    ret.Clear();
                    return ret;
                }
                return ret;
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
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return res;
            }
        }
    }
}
