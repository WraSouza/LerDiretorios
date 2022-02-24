// See https://aka.ms/new-console-template for more information

var path = @"C:\Users\wladimir.souza\Documents\DIO\Directory_DirectoryInfo\globo1";

LerDiretorios(path);
Console.WriteLine("Digite [ENTER] para finalizar");

static void LerDiretorios(string path)
{
    if(Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path,"*", SearchOption.AllDirectories);
    foreach(var dir in diretorios)
    {
        var dirInfo = new DirectoryInfo(dir);
        Console.WriteLine($"[Nome]:{dirInfo.Name}");
         Console.WriteLine($"[Raiz]:{dirInfo.Root}");

         if(dirInfo.Parent!=null)
        Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");

        Console.WriteLine("--------------");
        
    }
    }else{
        Console.WriteLine($"{path} Não Existe");
    }
    
}
