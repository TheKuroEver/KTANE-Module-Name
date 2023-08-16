public class PersonInfo
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Bosian { get; set; }

    public PersonInfo(string name, string department, string bosian) {
        Name = name;
        Department = department;
        Bosian = bosian;
    }
}