namespace Students
{
    internal enum Univesety
    {
        Sofiiski,
        Gabrvo
    }

    internal enum Specalty
    {
        TMM,
        KTT,
        KST,
    }

    internal enum Peoples
    {
        HP,
        GG
    }

    internal class Student
    {
        public string FirtsName { get; set; }

        public string SecondName { get; set; }

        public string TurdName { get; set; }

        public int Course { get; set; }

        public Specalty Specalty { get; set; }

        public Univesety Universety { get; set; }

        public string Mail { get; set; }

        public string TelefoneNumber { get; set; }

        public string asd { get; set; }
    }
}
