using System;



namespace Entidades
{
    
    public class Usuario 
    {
        public Usuario()
        {

        }
        private string nombre;
        private string apellido;
        private string sexo;
        private string email;
        private string clave;
        private bool claveTemporal;
        private bool loginStatus;
        private string rolAsignado;
        private string fechaDeNacimiento;
        private string palabraClave;
        private int legajo;

        public Usuario(string nombre, string apellido, string sexo, string email, string clave, bool tipoDeClave, bool loginStatus,  string nombreRol, string fechaDeNacimiento, string palabraClave,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.email = email;
            this.clave = clave;
            this.claveTemporal = tipoDeClave;
            this.loginStatus = loginStatus;
            this.rolAsignado = nombreRol;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.palabraClave = palabraClave;
            this.legajo = legajo;
            
        }

        [PrimaryKeyAtributo]
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public string Nombre 

        {       
            get {  return nombre; } 
            set {  nombre = value; }
        }
        public string Apellido
        { 
            get { return apellido; } 
            set { apellido = value; }
        
        }
        public string Sexo
        { 
            get {  return sexo; } 
            set {  sexo = value; } 
        }
        public string Email
        { 
            get { return email; } 
            set { email = value; } 
        }    
        public string Clave
        { 
            get {  return clave; } 
            set {  clave = value; } 
        }
        public bool ClaveTemporal
        { 
            get { return claveTemporal; } 
            set { claveTemporal = value; } 
        }
        public bool LoginStatus 
        { 
            get { return loginStatus; } 
            set { loginStatus = value; } 
        }
        public string Rol
        {
            get { return rolAsignado; }
            set { rolAsignado = value; }

        }
        public string FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }
        public string PalabraClave
        { 
            get { return palabraClave; } 
            set { palabraClave = value; } 
        }
       
        public static bool operator + (Usuario[] usuarios, Usuario usuario)
        {
            foreach (Usuario item in usuarios)
            {
                if(item.email== usuario.email)
                {
                    return false;
                }
            }
            Array.Resize(ref usuarios, 1);
            // Array.Resize(ref usuarios, usuarios.Length+1);
            usuarios[usuarios.Length - 1] = usuario;

            return true;
        }
       
       
    }
  


}