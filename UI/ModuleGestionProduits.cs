using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LocaMat.Metier;
using LocaMat.UI.Framework;

namespace LocaMat.UI
{
    public class ModuleGestionProduits
    {
        private Menu menu;
        private static readonly List<InformationAffichage> strategieAffichageProduits
            = new List<InformationAffichage>();

        static ModuleGestionProduits()
        {
            // On définit ici les propriétés qu'on veut afficher
            //  et la manière de les afficher
            strategieAffichageProduits = new List<InformationAffichage>
            {
                InformationAffichage.Creer<Produit>(x=>x.Id, "Id", 3),
                InformationAffichage.Creer<Produit>(x=>x.Nom, "Nom", 20),
                InformationAffichage.Creer<Produit>(x=>x.Description, "Description", 50),
                InformationAffichage.Creer<Produit>(x=>x.PrixJourHT, "Prix jour (HT)", 15),
                InformationAffichage.Creer<Produit>(x=>x.Categorie, "Catégorie", 20),
            };
        }

        private void InitialiserMenu()
        {
            this.menu = new Menu("Gestion des produits");
            this.menu.AjouterElement(new ElementMenu("1", "Afficher les produits")
            {
                FonctionAExecuter = this.AfficherProduits
            });
            this.menu.AjouterElement(new ElementMenu("2", "Ajouter un produit")
            {
                FonctionAExecuter = this.AjouterProduit
            });
            this.menu.AjouterElement(new ElementMenuQuitterMenu("R", "Revenir au menu principal..."));
        }

        public void Demarrer()
        {
            if (this.menu == null)
            {
                this.InitialiserMenu();
            }

            this.menu.Afficher();
        }

        private void AfficherProduits()
        {
            ConsoleHelper.AfficherEntete("Produits");

            var liste = Application.GetBaseDonnees().Produits.ToList();
            ConsoleHelper.AfficherListe(liste, strategieAffichageProduits);
        }

        private void AjouterProduit()
        {
            ConsoleHelper.AfficherEntete("Nouveau produit");

            Console.WriteLine("TO DO");
        }
    }
}
