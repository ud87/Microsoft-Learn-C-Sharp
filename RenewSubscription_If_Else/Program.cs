Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//daysUntilExpiration = 34;

if (daysUntilExpiration <= 10){
    if (daysUntilExpiration > 5){
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    } 
    else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1){
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.
Renew now and save 10%");    //@verbatim string allows to use multiline string
    }
    else if (daysUntilExpiration == 1){
        Console.WriteLine(@"Your subscription expires within a day!
Renew now and save 10%");
    }
    else {
    Console.WriteLine("Your subscription has expired.");    
    }
}  