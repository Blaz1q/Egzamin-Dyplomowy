using System;
using System.Collections.Generic;


namespace egzamin_dyplomowy
{
    public class Egzamin
    {
        private Student student;
        private Wykladowca promotor;
        private Wykladowca recenzent;
        private Wykladowca prodziekan;
        private List<Pytanie> pytania;

        public Egzamin(Student student, Wykladowca promotor, Wykladowca recenzent, Wykladowca prodziekan, List<Pytanie> pytania)
        {
            this.student = student;
            this.promotor = promotor;
            this.recenzent = recenzent;
            this.prodziekan = prodziekan;
            this.pytania = pytania;
        }
        public Egzamin() {
            this.student = new Student(-1,"","",-1,false,-1);
            this.promotor = new Promotor(-1,"","","Cskibidi");
        }
        public Wykladowca getPromotor() {
            return this.promotor;
        }
        public Wykladowca getRecenzent()
        {
            return this.recenzent;
        }
        public Wykladowca getProdziekan()
        {
            return this.prodziekan;
        }
        public Student getStudent() {
            return this.student;
        }
        public string GetSala()
        {
            return "Jakaś sala";
        }
        
    }
}
