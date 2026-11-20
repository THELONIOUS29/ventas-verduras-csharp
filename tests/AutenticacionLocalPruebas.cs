using System;
namespace WinAppDiseños {
  class AuthChecks {
    static int count=0;
    static void Check(bool condition) {count++;if(!condition)throw new Exception("Fallo de autorización");}
    static void Main() {
      string user="fixture-user", pass="fixture-password-0123456789";
      Check(AutenticacionLocal.Validar(user,pass,user,pass));
      Check(!AutenticacionLocal.Validar("incorrecto",pass,user,pass));
      Check(!AutenticacionLocal.Validar(user,"incorrecta",user,pass));
      Check(!AutenticacionLocal.Validar("","",user,pass));
      Check(!AutenticacionLocal.Validar(user,pass,"",pass));
      Check(!AutenticacionLocal.Validar(user,pass,user,""));
      Check(!AutenticacionLocal.Validar(user,"short",user,"short"));
      Check(!AutenticacionLocal.Validar(user,"CONFIGURAR_LOCALMENTE",user,"CONFIGURAR_LOCALMENTE"));
      Check(!AutenticacionLocal.Validar(null,null,user,pass));
      Console.WriteLine("C#: "+count+" casos de autenticación superados.");
    }
  }
}
