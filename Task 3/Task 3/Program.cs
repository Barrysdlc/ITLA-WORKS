using System;
using System.Collections.Generic;
using System.Linq;

public class Contactes
{
    private List<Contacte> llistaContactes;

    public Contactes()
    {
        llistaContactes = new List<Contacte>();
    }

    
    public void AfegirContacte(Contacte contacte)
    {
        
        if (!llistaContactes.Any(c => c.Nom == contacte.Nom && c.Cognom == contacte.Cognom))
        {
            llistaContactes.Add(contacte);
            Console.WriteLine($"Contacte {contacte.Nom} {contacte.Cognom} afegit correctament.");
        }
        else
        {
            Console.WriteLine($"El contacte {contacte.Nom} {contacte.Cognom} ja existeix.");
        }
    }

  
    public void EliminarContacte(string nom, string cognom)
    {
        var contacte = llistaContactes.FirstOrDefault(c =>
            c.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase) &&
            c.Cognom.Equals(cognom, StringComparison.OrdinalIgnoreCase));

        if (contacte != null)
        {
            llistaContactes.Remove(contacte);
            Console.WriteLine($"Contacte {nom} {cognom} eliminat correctament.");
        }
        else
        {
            Console.WriteLine($"No s'ha trobat el contacte {nom} {cognom}.");
        }
    }

   
    public List<Contacte> BuscarPerNom(string nom)
    {
        return llistaContactes
            .Where(c => c.Nom.Contains(nom, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

   
    public List<Contacte> BuscarPerCognom(string cognom)
    {
        return llistaContactes
            .Where(c => c.Cognom.Contains(cognom, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    
    public List<Contacte> BuscarPerTelefon(string telefon)
    {
        return llistaContactes
            .Where(c => c.Telefon.Contains(telefon))
            .ToList();
    }

    
    public void LlistarContactes()
    {
        if (llistaContactes.Count == 0)
        {
            Console.WriteLine("No hi ha contactes a la llista.");
            return;
        }

        Console.WriteLine("Llista de contactes:");
        Console.WriteLine("====================");

        foreach (var contacte in llistaContactes.OrderBy(c => c.Cognom).ThenBy(c => c.Nom))
        {
            Console.WriteLine(contacte);
        }
        Console.WriteLine($"Total: {llistaContactes.Count} contactes");
    }

    
    public int ObtenirNumeroContactes()
    {
        return llistaContactes.Count;
    }

   
    public bool ContacteExisteix(string nom, string cognom)
    {
        return llistaContactes.Any(c =>
            c.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase) &&
            c.Cognom.Equals(cognom, StringComparison.OrdinalIgnoreCase));
    }

   
    public Contacte ObtenirContacte(string nom, string cognom)
    {
        return llistaContactes.FirstOrDefault(c =>
            c.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase) &&
            c.Cognom.Equals(cognom, StringComparison.OrdinalIgnoreCase));
    }

    
    public bool ActualitzarContacte(string nom, string cognom, Contacte contacteActualitzat)
    {
        var contacteExistente = ObtenirContacte(nom, cognom);

        if (contacteExistente != null)
        {
            contacteExistente.Nom = contacteActualitzat.Nom;
            contacteExistente.Cognom = contacteActualitzat.Cognom;
            contacteExistente.Telefon = contacteActualitzat.Telefon;
            contacteExistente.Email = contacteActualitzat.Email;
            contacteExistente.Adreca = contacteActualitzat.Adreca;

            return true;
        }

        return false;
    }

    
    public void NetejarLlista()
    {
        llistaContactes.Clear();
        Console.WriteLine("Llista de contactes netejada.");
    }
}


public class Contacte
{
    public string Nom { get; set; }
    public string Cognom { get; set; }
    public string Telefon { get; set; }
    public string Email { get; set; }
    public string Adreca { get; set; }

    public Contacte(string nom, string cognom, string telefon, string email = "", string adreca = "")
    {
        Nom = nom;
        Cognom = cognom;
        Telefon = telefon;
        Email = email;
        Adreca = adreca;
    }

    public override string ToString()
    {
        return $"{Cognom}, {Nom} - Tel: {Telefon} {(string.IsNullOrEmpty(Email) ? "" : $"- Email: {Email}")} {(string.IsNullOrEmpty(Adreca) ? "" : $"- Adreça: {Adreca}")}";
    }
}


public class Program
{
    public static void Main()
    {
        
        Contactes agenda = new Contactes();


        agenda.AfegirContacte(new Contacte("Joan", "Garcia", "612345678", "joan@email.com", "Carrer Major 123"));
        agenda.AfegirContacte(new Contacte("Maria", "Lopez", "698765432", "maria@email.com"));
        agenda.AfegirContacte(new Contacte("Pere", "Martinez", "655443322"));

        
        agenda.LlistarContactes();

        
        var resultats = agenda.BuscarPerNom("Joan");
        Console.WriteLine("\nResultats de la cerca per 'Joan':");
        foreach (var contacte in resultats)
        {
            Console.WriteLine(contacte);
        }

        
        agenda.EliminarContacte("Pere", "Martinez");

        
        agenda.LlistarContactes();

        
        Console.WriteLine($"\nNombre total de contactes: {agenda.ObtenirNumeroContactes()}");
    }
}
