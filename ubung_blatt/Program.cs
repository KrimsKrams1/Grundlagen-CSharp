Console.WriteLine("Bitte geben sie ihre Körpergröße an (CM):");
double kl = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Bitte geben sie ihr Gewicht an (KG):");
double kg = Convert.ToDouble(Console.ReadLine());

double bmi = kg / kl * kl;

if (bmi)