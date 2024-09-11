var employees = GetEmployees();

var count = employees.Count();


foreach (var employee in employees)
{
  Console.WriteLine(employee);
}



IEnumerable<Employees> GetEmployees()
{

  var list = new List<Employees>();

  var lines = File.ReadAllLines("./employees.csv");



  //##############################################################
  //Comment out this
  //##############################################################
  foreach (var line in lines)
  {
    var splitLine = line.Split(';');
    yield return new Employees(splitLine[0], int.Parse(splitLine[1]));
  }



  ////##############################################################
  ////Comment in the code below.
  ////##############################################################

  //foreach (var line in lines)
  //{
  //  var splitLine = line.Split(';');
  //  list.Add(new Employees(splitLine[0], int.Parse(splitLine[1])));
  //}
  //return list;
}


record Employees(string Fullname, int Age);