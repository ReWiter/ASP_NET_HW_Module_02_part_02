namespace ASP_NET_HW_Module_02_part_02.Models
{
    public class Mercenery
    {
        public string NameM { get; set; }
        public string DescriptionM { get; set; }
        public string Gear { get; set; }
    }
    public class MerceneryChoosing : IMerceneryChoosing
    {
        public readonly string[] _name = { "Воин", "Копейщик", "Волшебник" };
        public readonly string[] _description = {"Специализируйщийся на ношение тяжёлой брони, имеет высокую выживаемость, оружейный мастер(меч и щит), роль в группе: танк/воин поддержки",
        "Специализируйщийся на ношение средней кольчужной брони,имеет среднюю, оружейный мастер(длинное копьё), роль в группе: нанесение урона",
        "Специализируйщийся на ношение тканевой брони, имеет низкую выживаемость, ученик школы (разрушения и востановления), роль в группе: нанесение урона/поддержка"};
        public readonly string[] _gear = {"Снаряжение: Тяжёлый доспех, меч и щит. \n" +
                "Навыки: массовая насмешка, тяжёлый удар, воодушивление, в пылу битвы(пассивный)",
           "Снаряжение: средня кольчужная броня, длинное копьё \n" +
                "Навыки: укол, глубокая рана, найти брешь(пассивный)",
        "Снаряжение: тканевая мантия, посох разрушения, церковный манускрипт \n" +
                "Навыки: огненный шар, напутствие, востановление лёгких ранений, тяга к знаниям(пассивный)"};
        public Mercenery addNewMercenery()
        {
            string name, discription, gear;
            var random = new Random();
            var merceneryindex=random.Next(3);
            name=_name[merceneryindex];
            discription=_description[merceneryindex];
            gear=_gear[merceneryindex];
            File.WriteAllText(name, name + '\n' + discription + '\n' + gear);
            File.WriteAllText(name + ".txt", name + '\n' + discription + '\n' + gear);
            File.WriteAllText(name + ".pdf", name + '\n' + discription + '\n' + gear);
            return new Mercenery { NameM = name, DescriptionM = discription + '\n', Gear = gear };
        }
    }
    public interface IMerceneryChoosing
    {
        Mercenery addNewMercenery();
    }
}
