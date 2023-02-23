// See https://aka.ms/new-console-template for more information
using System;

    class MyClass
    {
        private String nom,prenom;
        //constructeur
        public MyClass(String nom,String prenom){
            this.nom=nom;
            this.prenom=prenom;
        }

        public String GetNom(){
            return this.nom;
        }

        public void SetNom(String nom){
            this.nom=nom;
        }

        public String GetPrenom(){
            return this.prenom;
        }

        public void SetPrenom(String prenom){
            this.prenom=prenom;
        }

        override public String ToString(){
            return "{\n"+"nom : "+this.nom+"\nprenom : "+this.prenom+"\n}";
        }
        static void Main(String[] args)
        {
            // String nom,prenom;
            // Console.WriteLine("hello put your name");
            // nom=Console.ReadLine();
            // Console.WriteLine("put please your lastname");
            // prenom=Console.ReadLine();
            // Console.WriteLine("your name is "+nom+" your lastname is "+prenom);
            MyClass salem=new MyClass("salem","moussa");
            Console.WriteLine(salem);
            salem.SetNom("malick");
            Console.WriteLine(salem);
        }
    }

