﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace BackOffice_WebAPI
{
    public partial class F_COMPTET
    {
        public F_COMPTET()
        {
            F_DOCENTETECT_NumCentraleNavigations = new HashSet<F_DOCENTETE>();
            F_DOCENTETECT_NumPayeurNavigations = new HashSet<F_DOCENTETE>();
        }

        public string CT_Num { get; set; }
        public byte[] cbCT_Num { get; set; }
        public string CT_Intitule { get; set; }
        public short? CT_Type { get; set; }
        public string CG_NumPrinc { get; set; }
        public string CT_Qualite { get; set; }
        public string CT_Classement { get; set; }
        public byte[] cbCT_Classement { get; set; }
        public string CT_Contact { get; set; }
        public string CT_Adresse { get; set; }
        public string CT_Complement { get; set; }
        public string CT_CodePostal { get; set; }
        public byte[] cbCT_CodePostal { get; set; }
        public string CT_Ville { get; set; }
        public string CT_CodeRegion { get; set; }
        public string CT_Pays { get; set; }
        public string CT_Raccourci { get; set; }
        public byte[] cbCT_Raccourci { get; set; }
        public short? BT_Num { get; set; }
        public short? N_Devise { get; set; }
        public string CT_Ape { get; set; }
        public string CT_Identifiant { get; set; }
        public string CT_Siret { get; set; }
        public string CT_Statistique01 { get; set; }
        public string CT_Statistique02 { get; set; }
        public string CT_Statistique03 { get; set; }
        public string CT_Statistique04 { get; set; }
        public string CT_Statistique05 { get; set; }
        public string CT_Statistique06 { get; set; }
        public string CT_Statistique07 { get; set; }
        public string CT_Statistique08 { get; set; }
        public string CT_Statistique09 { get; set; }
        public string CT_Statistique10 { get; set; }
        public string CT_Commentaire { get; set; }
        public decimal? CT_Encours { get; set; }
        public decimal? CT_Assurance { get; set; }
        public string CT_NumPayeur { get; set; }
        public byte[] cbCT_NumPayeur { get; set; }
        public short? N_Risque { get; set; }
        public int? CO_No { get; set; }
        public int? cbCO_No { get; set; }
        public short? N_CatTarif { get; set; }
        public decimal? CT_Taux01 { get; set; }
        public decimal? CT_Taux02 { get; set; }
        public decimal? CT_Taux03 { get; set; }
        public decimal? CT_Taux04 { get; set; }
        public short? N_CatCompta { get; set; }
        public short? N_Period { get; set; }
        public short? CT_Facture { get; set; }
        public short? CT_BLFact { get; set; }
        public short? CT_Langue { get; set; }
        public short? N_Expedition { get; set; }
        public short? N_Condition { get; set; }
        public short? CT_Saut { get; set; }
        public short? CT_Lettrage { get; set; }
        public short? CT_ValidEch { get; set; }
        public short? CT_Sommeil { get; set; }
        public int? DE_No { get; set; }
        public int? cbDE_No { get; set; }
        public short? CT_ControlEnc { get; set; }
        public short? CT_NotRappel { get; set; }
        public short? N_Analytique { get; set; }
        public short? cbN_Analytique { get; set; }
        public string CA_Num { get; set; }
        public byte[] cbCA_Num { get; set; }
        public string CT_Telephone { get; set; }
        public string CT_Telecopie { get; set; }
        public string CT_EMail { get; set; }
        public string CT_Site { get; set; }
        public string CT_Coface { get; set; }
        public short? CT_Surveillance { get; set; }
        public DateTime? CT_SvDateCreate { get; set; }
        public string CT_SvFormeJuri { get; set; }
        public string CT_SvEffectif { get; set; }
        public decimal? CT_SvCA { get; set; }
        public decimal? CT_SvResultat { get; set; }
        public short? CT_SvIncident { get; set; }
        public DateTime? CT_SvDateIncid { get; set; }
        public short? CT_SvPrivil { get; set; }
        public string CT_SvRegul { get; set; }
        public string CT_SvCotation { get; set; }
        public DateTime? CT_SvDateMaj { get; set; }
        public string CT_SvObjetMaj { get; set; }
        public DateTime? CT_SvDateBilan { get; set; }
        public short? CT_SvNbMoisBilan { get; set; }
        public short? N_AnalytiqueIFRS { get; set; }
        public short? cbN_AnalytiqueIFRS { get; set; }
        public string CA_NumIFRS { get; set; }
        public short? CT_PrioriteLivr { get; set; }
        public short? CT_LivrPartielle { get; set; }
        public int? MR_No { get; set; }
        public int? cbMR_No { get; set; }
        public short? CT_NotPenal { get; set; }
        public int? EB_No { get; set; }
        public int? cbEB_No { get; set; }
        public string CT_NumCentrale { get; set; }
        public byte[] cbCT_NumCentrale { get; set; }
        public DateTime? CT_DateFermeDebut { get; set; }
        public DateTime? CT_DateFermeFin { get; set; }
        public short? CT_FactureElec { get; set; }
        public short? CT_TypeNIF { get; set; }
        public string CT_RepresentInt { get; set; }
        public string CT_RepresentNIF { get; set; }
        public short? CT_EdiCodeType { get; set; }
        public string CT_EdiCode { get; set; }
        public string CT_EdiCodeSage { get; set; }
        public short? CT_ProfilSoc { get; set; }
        public short? CT_StatutContrat { get; set; }
        public DateTime? CT_DateMAJ { get; set; }
        public short? CT_EchangeRappro { get; set; }
        public short? CT_EchangeCR { get; set; }
        public int? PI_NoEchange { get; set; }
        public int? cbPI_NoEchange { get; set; }
        public short? CT_BonAPayer { get; set; }
        public short? CT_DelaiTransport { get; set; }
        public short? CT_DelaiAppro { get; set; }
        public string CT_LangueISO2 { get; set; }
        public short? cbProt { get; set; }
        public int cbMarq { get; set; }
        public string cbCreateur { get; set; }
        public DateTime? cbModification { get; set; }
        public int? cbReplication { get; set; }
        public short? cbFlag { get; set; }
        public string ACODE { get; set; }
        public string CREDIT { get; set; }
        public decimal? Montant_Credit { get; set; }
        public decimal? OBJECTIF_MENSUEL { get; set; }
        public DateTime? DATE_FIN_CREDIT { get; set; }
        public string ECHEANCE { get; set; }
        public string GP { get; set; }
        public decimal? SOLDE { get; set; }
        public string TYPE_CLT { get; set; }
        public decimal? Taux_Ret { get; set; }
        public string anx { get; set; }
        public string TypMont { get; set; }
        public DateTime? Date_Debut_Credit { get; set; }
        public DateTime? cbCreation { get; set; }
        public Guid? cbCreationUser { get; set; }
        public short? CT_AnnulationCR { get; set; }
        public short? CT_CessionCreance { get; set; }
        public string CT_Facebook { get; set; }
        public string CT_LinkedIn { get; set; }
        public short? CT_ExclureTrait { get; set; }
        public short? CT_GDPR { get; set; }
        public short? CT_Prospect { get; set; }
        public byte[] cbCG_NumPrinc { get; set; }
        public DateTime? CT_DATECREATE { get; set; }

        public virtual F_COLLABORATEUR cbCO_NoNavigation { get; set; }
        public virtual ICollection<F_DOCENTETE> F_DOCENTETECT_NumCentraleNavigations { get; set; }
        public virtual ICollection<F_DOCENTETE> F_DOCENTETECT_NumPayeurNavigations { get; set; }
    }
}