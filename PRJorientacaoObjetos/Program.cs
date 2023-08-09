using PRJorientacaoObjetos.ClasseDerivada;

Pessoa pessoa1 = new Pessoa();
pessoa1.CPF = 4321;
pessoa1.Dados(1,"Dailson", "Hortolândia-SP");
pessoa1.Situacao();

CPU cpuDailson = new CPU();
cpuDailson.Montar("Assus", "1050", 8, 500, "TGT", "Windows");
cpuDailson.MostrarConfig();

Pac pacDailson = new Pac();
pacDailson.Entregar("Pac");
pacDailson.Update();

Empresa empresa1 = new Empresa();
empresa1.CNPJ = 3214;
empresa1.Dados(2,"DLN", "Campinas-SP");
empresa1.Situacao();

CPU cpuDLN = new CPU();
cpuDLN.Montar("Positivo", "1030", 16, 1000, "ONE", "Linux");
cpuDLN.MostrarConfig();

Note noteDLN = new Note();
noteDLN.Montar("Lenovo", "3060 TI", 32, 1000, "Power", "Windows");
noteDLN.Perifericos(144, "Mecânico", 180);
noteDLN.MostrarConfig();

Sedex sedexDLN = new Sedex();
sedexDLN.Entregar("Sedex");
sedexDLN.Update();
