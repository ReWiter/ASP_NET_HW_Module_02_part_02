namespace ASP_NET_HW_Module_02_part_02.Models
{
    public class Device
    {
        public string named { get; set; }
        public string descriptiond { get; set; }
    }
    public class DeviceChoosing : IDeviceChoosing
    {
        public readonly string[] _name = { "Кофемолка", "Миксер", "Блендер" };
        public readonly string[] _description = {
            "приспособление для ручного, механического или электрического измельчения кофейных зёрен и других сыпучих продуктов" +
                " (сахара, сухарей и т. п.) с помощью вращающихся жерновов, расстояние между которыми регулируется винтом",
            "Ми́ксер (англ. mixer — «мешалка» от др.-греч. μῖξις — «смешение, смесь») — устройство для приготовления пищи методом перемешивания её компонентов до создания однородной массы и обогащения взбиваемой жидкости воздухом." +
                " Миксером взбивают и замешивают яйца, сливки, коктейли, мусс, омлет, тесто, пюре, соусы и другие продукты.",
            "Бле́ндер (англ. blender «смеситель, смешиватель») — электроприбор, предназначенный для измельчения пищи," +
                " приготовления эмульсий, пюре, взбивания напитков, муссов и т. п., а также колки льда."
        };
        public Device addNewDevice()
        {
            string name, discription;
            var random = new Random();
            var deviceindex = random.Next(3);
            name = _name[deviceindex];
            discription = _description[deviceindex];
            File.WriteAllText(name, name + '\n' + discription);
            File.WriteAllText(name + ".txt", name + '\n' + discription);
            File.WriteAllText(name + ".pdf", name + '\n' + discription);
            return new Device { named = name, descriptiond = discription };
        }
    }
    public interface IDeviceChoosing
    {
        Device addNewDevice();
    }
}
