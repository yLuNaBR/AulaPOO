using AP2_POO.Data;
using AP2_POO.Data.Repositories;

var context = new DataContext();
RegisterRepository registerRepository = new RegisterRepository();

bool sair = false;

while(!sair)
{
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1. Cadastrar Médico");
    Console.WriteLine("2. Cadastrar Paciente");
    Console.WriteLine("3. Marcar Consulta");
    Console.WriteLine("4. Sair");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            registerRepository.RegisterDoctor(context);
            break;
        case "2":
            registerRepository.RegisterPacient(context);
            break;
        case "3":
            registerRepository.MakeAnAppointment(context);
            break;
        case "4":
            sair = true;
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
