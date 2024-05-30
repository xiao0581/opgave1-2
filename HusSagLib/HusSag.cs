namespace HusSagLib
{
    public class HusSag
    {
        public int Id { get; set; }
        public string Vej { get; set; }
        public int HusNr { get; set; }
        public string By { get; set; }
        public int Pris { get; set; }

        public override string ToString()
        {
            return $"{Id} {Vej} {HusNr} {By} {Pris}";
        }

    }
}
