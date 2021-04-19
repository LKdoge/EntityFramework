namespace API.Entities// Esta linea indica en que carpeta esta contenida la calse
//Aqui definiremos las entidades que han de interactuar con nuestra Aplicacion

{
    public class AppUser
    {
        public int Id{get; set;}//Aqui no tenemos que codificar explicitamente el Get n Set
        
        public string UserName{ get; set;}

    }
}