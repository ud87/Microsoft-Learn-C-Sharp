//foreach statement processes array elements in increasing index order, starting with index 0 and ending with index Length - 1

/*
Suppose you work for a manufacturing company. The company needs you to complete an inventory of your warehouse to determine 
the number of products that are ready to ship. In addition to the total number of finished products, you need to report the 
number of finished products stored in each individual bin in your warehouse, along with a running total. This running total 
will be used to create an audit trail so you can double-check your work and identify "shrinkage".
*/

int[] inventory = [200, 450, 175, 250];
int sum = 0;
int bin = 0;

foreach (int items in inventory){
    sum += items;
    bin++;      //increases the value by 1 i.e. bin = bin+ 1;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
