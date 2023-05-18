// See https://aka.ms/new-console-template for more information
using Lopez_RoboDialer.Models;

List<Phone> phones = new List<Phone>
{
    new HomePhone("CompuTest", "(303) 985-5060", 1),
    new CellPhone("Curtis Manufacturing", "(603) 532-4123",2),
    new HomePhone("Data Functions", "(800) 876-2524", 1),
    new HomePhone("Donnay Repair", "(708) 397-3330", 1),
    new HomePhone("ErgoNomic Inc", "(360) 434-3894", 1),
    new HomePhone("ErgoSource", "(800) 969-4374", 1),
    new CellPhone("Fox Bay Industries", "(800) 874-8527", 2),
    new CellPhone("Glare-Guard", "(800) 545-6254",2),
    new CellPhone("Hazard Comm Specialists", "(407) 783-6641",2),
    new CellPhone("Komfort Support", "(714) 472-4409", 2)
};

phones.ForEach(phone =>
{
    string output = "";
    if (phone is HomePhone)
        output = ((HomePhone)phone).Dial();
    if (phone is CellPhone)
        output = ((CellPhone)phone).Dial();
    Console.WriteLine(output);
});