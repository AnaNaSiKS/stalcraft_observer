using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace stalcraft_observer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Item> items = new List<Item>();

        public MainWindow()
        {
            InitializeComponent();
            items.Add(new Item("0r2g1", "9А-91", "assault_rifle"));
            items.Add(new Item("0r2zd", "«Баланс»", "assault_rifle"));
            items.Add(new Item("0r3nd", "Поношенная HK G3A1", "assault_rifle"));
            items.Add(new Item("1r731", "Kbk wz. 88 Tantal", "assault_rifle"));
            items.Add(new Item("1r7g1", "Steyr AUG A3", "assault_rifle"));
            items.Add(new Item("1rd56", "АКС-74", "assault_rifle"));
            items.Add(new Item("2ony6", "IWI Tavor X95", "assault_rifle"));
            items.Add(new Item("3gn5g", "ТКБ-0146М", "assault_rifle"));
            items.Add(new Item("4q09p", "HK G3A1", "assault_rifle"));
            items.Add(new Item("4qnwn", "ОЦ-14М «Шторм»", "assault_rifle"));
            items.Add(new Item("5ld1g", "ОЦ-14 «Гроза»", "assault_rifle"));
            items.Add(new Item("5ldkg", "АКМ", "assault_rifle"));
            items.Add(new Item("5ldwg", "АКС-74У", "assault_rifle"));
            items.Add(new Item("5ln40", "LR-300", "assault_rifle"));
            items.Add(new Item("5lnw0", "FN FAL", "assault_rifle"));
            items.Add(new Item("7lnj7", "SA-58 CTC", "assault_rifle"));
            items.Add(new Item("7lrz3", "АК-103", "assault_rifle"));
            items.Add(new Item("969jz", "Steyr AUG A2", "assault_rifle"));
            items.Add(new Item("96my0", "АЛК-22 «Стрекоза»", "assault_rifle"));
            items.Add(new Item("dmjdn", "АК-308", "assault_rifle"));
            items.Add(new Item("dmjwn", "HK416", "assault_rifle"));
            items.Add(new Item("dmqk5", "АМ-17", "assault_rifle"));
            items.Add(new Item("g4060", "L85A1", "assault_rifle"));
            items.Add(new Item("g40y0", "Поношенный АН-94 «Абакан»", "assault_rifle"));
            items.Add(new Item("g4mdp", "АК-12", "assault_rifle"));
            items.Add(new Item("j5l37", "АЕК-971", "assault_rifle"));
            items.Add(new Item("j5l77", "Поношенная L85A1", "assault_rifle"));
            items.Add(new Item("j5lk7", "M16A3", "assault_rifle"));
            items.Add(new Item("j5od6", "FAMAS G2", "assault_rifle"));
            items.Add(new Item("knl30", "FN F2000 Tactical", "assault_rifle"));
            items.Add(new Item("knl70", "АКС чистильщика", "assault_rifle"));
            items.Add(new Item("lyl3j", "АШ-12", "assault_rifle"));
            items.Add(new Item("lyl7j", "Поношенная M16A2", "assault_rifle"));
            items.Add(new Item("lyljj", "M4 LB", "assault_rifle"));
            items.Add(new Item("m023j", "Поношенный SIG SG 550", "assault_rifle"));
            items.Add(new Item("m026j", "Поношенный АС «Вал»", "assault_rifle"));
            items.Add(new Item("n4md3", "HK XM8S", "assault_rifle"));
            items.Add(new Item("okv0o", "M16A2", "assault_rifle"));
            items.Add(new Item("okv7o", "АН-94 «Абакан»", "assault_rifle"));
            items.Add(new Item("p63d2", "HK417", "assault_rifle"));
            items.Add(new Item("p63g2", "Steyr AUG A1", "assault_rifle"));
            items.Add(new Item("p6r26", "FN F2000", "assault_rifle"));
            items.Add(new Item("qjv16", "Поношенная «Гроза»", "assault_rifle"));
            items.Add(new Item("rw27g", "«Рапира»", "assault_rifle"));
            items.Add(new Item("rwrgg", "Старая HK G3A1", "assault_rifle"));
            items.Add(new Item("rwrng", "АН-94М «Абакан»", "assault_rifle"));
            items.Add(new Item("vj2zd", "DSA-58", "assault_rifle"));
            items.Add(new Item("wj75o", "FN SCAR-H", "assault_rifle"));
            items.Add(new Item("wjo4p", "А-545", "assault_rifle"));
            items.Add(new Item("wjo5p", "Поношенный АКС-74У", "assault_rifle"));
            items.Add(new Item("wjodp", "Поношенный АКС-74", "assault_rifle"));
            items.Add(new Item("wjogp", "SIG SG 550", "assault_rifle"));
            items.Add(new Item("y32lo", "FN SCAR-L", "assault_rifle"));
            items.Add(new Item("y32wo", "HK XM8", "assault_rifle"));
            items.Add(new Item("y375z", "АС «Вал»", "assault_rifle"));
            items.Add(new Item("zz2rn", "АК-105", "assault_rifle"));
            items.Add(new Item("zz7j2", "HK G36C", "assault_rifle"));
            items.Add(new Item("zz7y2", "M4A1", "assault_rifle"));
            items.Add(new Item("1gmg", "Детектор узкого диапазона «Бурят»", "device"));
            items.Add(new Item("5wd1", "СН-2 «Нога»", "device"));
            items.Add(new Item("9j0l", "Детектор узкого диапазона «Свеча»", "device"));
            items.Add(new Item("gd06", "СН-1 «Блин»", "device"));
            items.Add(new Item("gdj6", "Детектор узкого диапазона «Эльбрус»", "device"));
            items.Add(new Item("yw7k", "СН-2у «Ножка»", "device"));
            items.Add(new Item("z47y", "СН-1у «Блинчик»", "device"));
            items.Add(new Item("4qnyn", "ПТРД-М", "heavy"));
            items.Add(new Item("g4vj5", "РГ-6", "heavy"));
            items.Add(new Item("wj6m3", "«Огниво»", "heavy"));
            items.Add(new Item("zzl6m", "РПГ-7", "heavy"));
            items.Add(new Item("zzlvm", "Огнемет", "heavy"));
            items.Add(new Item("1rdnq", "ДП", "machine_gun"));
            items.Add(new Item("2onz6", "РПК-16", "machine_gun"));
            items.Add(new Item("4q0rl", "Поношенный ПКП", "machine_gun"));
            items.Add(new Item("5ldm4", "Поношенный РПД", "machine_gun"));
            items.Add(new Item("5lnq4", "MG 42", "machine_gun"));
            items.Add(new Item("g405g", "РПК-74", "machine_gun"));
            items.Add(new Item("g407g", "L86A1", "machine_gun"));
            items.Add(new Item("rw255", "M249 SAW", "machine_gun"));
            items.Add(new Item("wj7qo", "РПК", "machine_gun"));
            items.Add(new Item("zz2g9", "ПКП «Печенег»", "machine_gun"));
            items.Add(new Item("zz7m9", "РПД", "machine_gun"));
            items.Add(new Item("1rdnq", "ДП", "machine_gun"));
            items.Add(new Item("0rq2k", "Ледоруб", "melee"));
            items.Add(new Item("0rqkk", "«Пламенный привет»", "melee"));
            items.Add(new Item("0rqqk", "УВСР", "melee"));
            items.Add(new Item("1rj7r", "Изделие 6Х4", "melee"));
            items.Add(new Item("1rjjr", "Старый серп", "melee"));
            items.Add(new Item("1rjqr", "Мясницкий крюк", "melee"));
            items.Add(new Item("1rjvr", "«Гладиус»", "melee"));
            items.Add(new Item("2ollv", "Классический M9", "melee"));
            items.Add(new Item("2olnv", "Бита с гвоздями", "melee"));
            items.Add(new Item("3g991", "Мясницкий нож", "melee"));
            items.Add(new Item("3g9n1", "Алюминиевая бита", "melee"));
            items.Add(new Item("4q11j", "Нож из шипа", "melee"));
            items.Add(new Item("4q1nj", "Кукри", "melee"));
            items.Add(new Item("5lggo", "Огненная бритва", "melee"));
            items.Add(new Item("5lgno", "Glock Feldmesser 78", "melee"));
            items.Add(new Item("5lgvo", "Синобигатана", "melee"));
            items.Add(new Item("6wz1n", "«Флюорит»", "melee"));
            items.Add(new Item("6wz6n", "Мачете Survival SP8 Ontario", "melee"));
            items.Add(new Item("6wzzn", "Едкая пила", "melee"));
            items.Add(new Item("7l559", "Нож с обратным хватом", "melee"));
            items.Add(new Item("7l5g9", "«Эндшпиль»", "melee"));
            items.Add(new Item("7l5n9", "Тесак", "melee"));
            items.Add(new Item("96w5q", "«Рвач»", "melee"));
            items.Add(new Item("96w9q", "Охотничий нож", "melee"));
            items.Add(new Item("96wwq", "Кусок трубы", "melee"));
            items.Add(new Item("dmvjg", "Телескопическая дубинка", "melee"));
            items.Add(new Item("dmvog", "Тактический нож Ka-Bar BKR3", "melee"));
            items.Add(new Item("dmvvg", "«Друг болотника»", "melee"));
            items.Add(new Item("g4vmn", "Монтировка", "melee"));
            items.Add(new Item("g4vvn", "Новогодняя лопата", "melee"));
            items.Add(new Item("j5vol", "Танто с кольцом", "melee"));
            items.Add(new Item("j5vvl", "Тесак военсталов", "melee"));
            items.Add(new Item("knvmj", "Jagdkommando", "melee"));
            items.Add(new Item("knvvj", "Ледяной кукри", "melee"));
            items.Add(new Item("lyv22", "Охотничий мачете", "melee"));
            items.Add(new Item("lyvv2", "Твичер", "melee"));
            items.Add(new Item("m0v5k", "Костяной нож", "melee"));
            items.Add(new Item("m0vmk", "Топор", "melee"));
            items.Add(new Item("n4229", "Керамбит из когтя", "melee"));
            items.Add(new Item("n42m9", "Мачете «ЭМЧес»", "melee"));
            items.Add(new Item("n42y9", "Керамбит Steel Tiger", "melee"));
            items.Add(new Item("ok995", "Диверсионный нож", "melee"));
            items.Add(new Item("ok9m5", "Молоток", "melee"));
            items.Add(new Item("ok9w5", "Мизерикорд", "melee"));
            items.Add(new Item("p611d", "Шипастая дубинка", "melee"));
            items.Add(new Item("p613d", "Штык-нож M9", "melee"));
            items.Add(new Item("p614d", "Боевой нож «Катран-1»", "melee"));
            items.Add(new Item("qjg24", "Саперная лопата", "melee"));
            items.Add(new Item("qjgg4", "Ледяной ледоруб", "melee"));
            items.Add(new Item("rwz2z", "Русский штык", "melee"));
            items.Add(new Item("rwzqz", "Ритуальный топор", "melee"));
            items.Add(new Item("rwzzz", "Нож 6Х9", "melee"));
            items.Add(new Item("vj427", "M48 Tomahawk", "melee"));
            items.Add(new Item("vj497", "Казачья шашка", "melee"));
            items.Add(new Item("wj66z", "Прижигатель", "melee"));
            items.Add(new Item("wj67z", "КО-1", "melee"));
            items.Add(new Item("y3j20", "Gerber Downrange Tomahawk", "melee"));
            items.Add(new Item("y3jj0", "Кислотная бритва", "melee"));
            items.Add(new Item("zzl2k", "ОЦ-04", "melee"));
            items.Add(new Item("zzl5k", "Сосулька", "melee"));
            items.Add(new Item("zzllk", "Бритва", "melee"));
            items.Add(new Item("1r77r", "Форт-12", "pistol"));
            items.Add(new Item("1r7dr", "ПМ", "pistol"));
            items.Add(new Item("1rj9g", "ПМ вечного новичка", "pistol"));
            items.Add(new Item("4qn6j", "ОЦ-33 «Пернач»", "pistol"));
            items.Add(new Item("5ln9o", "Glock 17", "pistol"));
            items.Add(new Item("5lngo", "Mauser C96", "pistol"));
            items.Add(new Item("969mq", "ПБ", "pistol"));
            items.Add(new Item("g4m0n", "ТТ", "pistol"));
            items.Add(new Item("g4mgp", "IMI Micro Uzi", "pistol"));
            items.Add(new Item("g4mmn", "Walther P99", "pistol"));
            items.Add(new Item("g4mqp", "АПС", "pistol"));
            items.Add(new Item("g4mvn", "Beretta 92FS", "pistol"));
            items.Add(new Item("g4vk6", "«Мечта»", "pistol"));
            items.Add(new Item("j5or6", "Glock 18C", "pistol"));
            items.Add(new Item("knmgj", "Colt Python", "pistol"));
            items.Add(new Item("ly2z2", "РШ-12", "pistol"));
            items.Add(new Item("m0m5k", "SIG Sauer P320", "pistol"));
            items.Add(new Item("n4m93", "МР-412", "pistol"));
            items.Add(new Item("rwzmv", "«Пчела»", "pistol"));
            items.Add(new Item("wj71z", "СР-1 «Гюрза»", "pistol"));
            items.Add(new Item("wj76z", "Поношенная Beretta 93R", "pistol"));
            items.Add(new Item("y32j0", "Beretta 93R", "pistol"));
            items.Add(new Item("y32po", "Ingram MAC-10", "pistol"));
            items.Add(new Item("y32z0", "Desert Eagle Mark XIX", "pistol"));
            items.Add(new Item("zz22k", "Р-92", "pistol"));
            items.Add(new Item("zz25k", "SW1911", "pistol"));
            items.Add(new Item("zz2lk", "Browning Hi-Power", "pistol"));
            items.Add(new Item("zz2pn", "ПММ", "pistol"));
        }

        private async void ButtonGetHistory_Click(object sender, RoutedEventArgs e)
        {
            ItemsHelper.ShowPrices("lynkj");
        }

        private void Weapon(object sender, SelectionChangedEventArgs e)
        {
            if (WeaponClass.SelectedItem != null)
            {
                var selectValue = (ComboBoxItem)WeaponClass.SelectedItem;
                List<string> strings = new List<string>();
                strings = Names(selectValue.Content.ToString());

                NameId.ItemsSource = strings;
            }
        }

        public List<string> Names (string name) {
            List<string> names = new List<string>();

            switch (name) 
            {
                case "assault_rifle":
                    foreach (var item in items)
                    {
                        if (item.Class == "assault_rifle")
                        {
                            names.Add(item.name);
                        }
                        
                    }
                    return names;
                    break;
                case "device":
                    names = new List<string>();
                    break;
                case "heavy":
                    names = new List<string>();
                    break;
                case "machine_gun":
                    names = new List<string>();
                    break;
                case "melee":
                    names = new List<string>();
                    break;
                case "pistol": 
                    break;
                case "shotgun_rifle": 
                    break;
                case "sniper_rifle": 
                    break;
                case "submachine_gun": 
                    break;
            }
            return names;
        }

        private void History(object sender, SelectionChangedEventArgs e)
        {
            if (NameId.SelectedItem != null)
            {
                var selectValue = NameId.SelectedItem;

                foreach (Item item in items)
                {
                    if (item.name == selectValue.ToString())
                    {
                        ItemsHelper.ShowPrices(item.id);
                    }
                }
            }
        }
    }
}
