namespace ASP_NET_HW_Module_02_part_02.Models
{
    public class cocktail
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Making { get; set; }
    }
    public class CocktailChoosing : ICocktailChoosing
    {
        private readonly string[] _name = { "Негрони", "Руж" };
        private readonly string[] _description = { "Хотите попробовать \"Негрони\"?\n" +
                " Это крепкий горький коктейль на основе джина с добавлением биттера и красного вермута.\n" +
                " Идеален как в качестве аперитива, так и дижестива.\n" +
                "Один из самых популярных коктейлей в мире, потрясающе вкусный и гармоничный.\n",
        "Вам нравятся шорты? \n" +
                "Тогда попробуйте этот ягодный, тропический и сладкий коктейль на основе водки, алкогольный и крепкий.\n"};
        private readonly string[] _making = {"Лондонский сухой джин 30мл \n" +
                "Красный вермут 30мл \n"+
                "Красный биттер 30мл \n" +
                "Апельсиновая цедра 1шт \n" +
                "Лёд в кубиках 120г", "Домашняя ванильная водка 40мл \n" +
                "Ликёр личи Fruko Schulz 50мл \n" +
                "Лимонный сок 15мл \n" +
                "Малиновое пюре 20г \n" +
                "Лёд в кубиках 200г \n"};
        public cocktail addNewCocktail()
        {
            string name, discription, making;
            var random = new Random();
            var cocktailindex = random.Next(2);
            name = _name[cocktailindex];
            discription = _description[cocktailindex];
            making = _making[cocktailindex];
            File.WriteAllText(name, name + '\n' + discription + '\n' + making);
            File.WriteAllText(name+".txt", name + '\n' + discription + '\n' + making);
            File.WriteAllText(name+".pdf", name + '\n' + discription + '\n' + making);
            return new cocktail { Name = name, Description = discription+'\n', Making = making };
        }
    }
    public interface ICocktailChoosing
    {
        cocktail addNewCocktail();
    }
}