﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace BackOffice_WebAPI
{
    public partial class F_COLLABORATEUR
    {
        public F_COLLABORATEUR()
        {
            F_COMPTETs = new HashSet<F_COMPTET>();
            F_DOCENTETEcbCO_NoCaissierNavigations = new HashSet<F_DOCENTETE>();
            F_DOCENTETEcbCO_NoNavigations = new HashSet<F_DOCENTETE>();
            F_DOCLIGNEs = new HashSet<F_DOCLIGNE>();
        }

        public int? CO_No { get; set; }
        public string CO_Nom { get; set; }
        public byte[] cbCO_Nom { get; set; }
        public string CO_Prenom { get; set; }
        public byte[] cbCO_Prenom { get; set; }
        public string CO_Fonction { get; set; }
        public byte[] cbCO_Fonction { get; set; }
        public string CO_Adresse { get; set; }
        public string CO_Complement { get; set; }
        public string CO_CodePostal { get; set; }
        public string CO_Ville { get; set; }
        public string CO_CodeRegion { get; set; }
        public string CO_Pays { get; set; }
        public string CO_Service { get; set; }
        public short? CO_Vendeur { get; set; }
        public short? CO_Caissier { get; set; }
        public short? CO_Acheteur { get; set; }
        public string CO_Telephone { get; set; }
        public string CO_Telecopie { get; set; }
        public string CO_EMail { get; set; }
        public short? CO_Receptionnaire { get; set; }
        public int? PROT_No { get; set; }
        public int? cbPROT_No { get; set; }
        public string CO_TelPortable { get; set; }
        public short? CO_ChargeRecouvr { get; set; }
        public string CO_Matricule { get; set; }
        public byte[] cbCO_Matricule { get; set; }
        public short? CO_Financier { get; set; }
        public short? CO_Transmission { get; set; }
        public short? cbProt { get; set; }
        public int cbMarq { get; set; }
        public string cbCreateur { get; set; }
        public DateTime? cbModification { get; set; }
        public int? cbReplication { get; set; }
        public short? cbFlag { get; set; }
        public DateTime? cbCreation { get; set; }
        public Guid? cbCreationUser { get; set; }
        public string CO_Facebook { get; set; }
        public string CO_LinkedIn { get; set; }
        public string CO_Skype { get; set; }
        public short? CO_Sommeil { get; set; }

        public virtual ICollection<F_COMPTET> F_COMPTETs { get; set; }
        public virtual ICollection<F_DOCENTETE> F_DOCENTETEcbCO_NoCaissierNavigations { get; set; }
        public virtual ICollection<F_DOCENTETE> F_DOCENTETEcbCO_NoNavigations { get; set; }
        public virtual ICollection<F_DOCLIGNE> F_DOCLIGNEs { get; set; }
    }
}