DateTimeExemplo();

static void DateTimeExemplo(){
    DateTime dataInicio = new DateTime(2024, 10, 01, 14, 25, 32);
    Console.WriteLine("Data de início: " + dataInicio.ToString("dd/mm/yyyy HH:mm:ss"));
    DateTime hoje = DateTime.Today;
    Console.WriteLine("hoje: " + hoje);
    DateTime agora = DateTime.Now;
    Console.WriteLine("agora: " + agora);

    DayOfWeek diaDaSemana = hoje.DayOfWeek;
    Console.WriteLine("Dia da semana: " + diaDaSemana);
    DateTime dataFinal = hoje.AddDays(10);
    Console.WriteLine("data final é: " + dataFinal.ToString("dd/mm/yyyy HH:mm:ss"));
    bool horarioDeVerao = agora.IsDaylightSavingTime();
    Console.WriteLine("é horario de verão? " + horarioDeVerao);
    
    DateOnly soAData = new DateOnly(2024, 10, 01);
    Console.WriteLine("só a data agora: " + soAData);
    DateOnly soADataDoAgora = DateOnly.FromDateTime(DateTime.Now);
    Console.WriteLine("só a data agora: " + soADataDoAgora);

    //HORÁRIO DE TRABALHO:
    DateTime horaEntrada = DateTime.Now;
    TimeSpan horaDeTrabalho = new TimeSpan(8, 0, 0);
    DateTime horaDeSaida = horaEntrada.Add(horaDeTrabalho);
    Console.WriteLine($"Hora de entrada: " + horaEntrada);
    Console.WriteLine($"Hora de saída: " + horaDeSaida);
    
    TimeOnly horaDeEntrada = new TimeOnly(22, 19, 24);
    Console.WriteLine($"hora de entrada: " + horaDeEntrada);
         
};
