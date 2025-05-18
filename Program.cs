using DesafioPOO.Models;

Console.WriteLine("Iphone: ");
Iphone i = new Iphone("99982-2313", "18", "12345678", 124);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("whastzap", 50);
i.InstalarAplicativo("gitHub", 20);
i.InstalarAplicativo("Likedin", 80);
i.MostrandoAplicativos();

Console.WriteLine("Nokia: ");
Nokia n = new Nokia("99973-3424", "M65", "12345678", 164);
n.Ligar();
n.ReceberLigacao();
n.MostrandoAplicativos();
n.InstalarAplicativo("youtube", 30);
n.InstalarAplicativo("Likedin", 80);
n.InstalarAplicativo("telagram", 20);
n.MostrandoAplicativos();

