namespace ASP_NET_HW_Module_02_part_02.Models
{
    public class FigureI
    {
        public string name { get; set; }
        public string description { get; set; }
    }
    public class FigureIChoosing : IFigureIChoosing
    {

        public readonly string[] _name = { "круг","квадрат","прямоугольник" };
        public readonly string[] _description = { "Простейшая геометрическая фигура, все точки на границе которого равноудалены от центра. " +
                "Иными словами, часть плоскости, лежащая внутри окружности." +
                " Границей круга является окружность.", "Квадрат — правильный четырёхугольник, у которого все стороны и углы равны между собой." +
                " У квадрата есть две диагонали, соединяющие несмежные вершины.", "Прямоугольник — четырёхугольник, у которого все углы прямые (равны 90°).\n" +
                "Слово «прямоугольник» является переводом лат. rectangulus, которое, в свою очередь, представляет собой комбинацию лат. «rectus» (прямой, правильный) и лат. «angulus» (угол)." +
                "В евклидовой геометрии для того, чтобы четырёхугольник был прямоугольником, достаточно, чтобы хотя бы три его угла были прямые, тогда четвёртый угол в силу теоремы о сумме углов многоугольника также будет равен 90°." 
        };
        public FigureI addNewFigureI()
        {
            string name, discription;
            var random = new Random();
            var figreindex=random.Next(3);
            name=_name[figreindex];
            discription=_description[figreindex];
            File.WriteAllText(name, name + '\n' + discription);
            File.WriteAllText(name + ".txt", name + '\n' + discription);
            File.WriteAllText(name + ".pdf", name + '\n' + discription);
            return new FigureI { name = name,description = discription };
        }
    }
    public interface IFigureIChoosing
    {
        FigureI addNewFigureI();
    }
}
