// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;

Customer c1 = new Customer(9202278, "Burak", "YILDIRIM", "Turkey");
Customer c2 = new Customer(2568778, "Serbaycan", "Metin", "Holland");
Customer c3 = new Customer(6589478, "Ülkü", "TURAN", "Turkey");
Customer c4 = new Customer(1056248, "Marc", "Favorito TRINIDAD", "Philipines");


CustomerManager CustomerManager = new CustomerManager();

CustomerManager.Affixer(c1);
CustomerManager.Affixer(c2);
CustomerManager.Affixer(c3);
CustomerManager.Affixer(c4);
CustomerManager.List();

CustomerManager.CustomerRemover(c1.GetMusteriNo(c1));
CustomerManager.List();