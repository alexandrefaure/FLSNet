
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server Compact Edition
-- --------------------------------------------------
-- Date Created: 11/07/2017 23:58:36
-- Generated from EDMX file: D:\Visual Studio 2017\Projets\FORMOTS\FormotsDAL\EntityModel.edmx
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

    ALTER TABLE [formulaire_act] DROP CONSTRAINT [FK_IdDossier_Act];
GO
    ALTER TABLE [formulaire_cda] DROP CONSTRAINT [FK_IdDossier_Cda];
GO
    ALTER TABLE [formulaire_cfp] DROP CONSTRAINT [FK_IdDossier_Cfp];
GO
    ALTER TABLE [formulaire_ecv] DROP CONSTRAINT [FK_IdDossier_Ecv];
GO
    ALTER TABLE [formulaire_seo] DROP CONSTRAINT [FK_IdDossier_Seo];
GO
    ALTER TABLE [formulaire_sfa] DROP CONSTRAINT [FK_IdDossier_Sfa];
GO
    ALTER TABLE [dossiers] DROP CONSTRAINT [FK_MedecinAppelantId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- NOTE: if the table does not exist, an ignorable error will be reported.
-- --------------------------------------------------

    DROP TABLE [appelant_medecins];
GO
    DROP TABLE [dossiers];
GO
    DROP TABLE [formulaire_act];
GO
    DROP TABLE [formulaire_cda];
GO
    DROP TABLE [formulaire_cfp];
GO
    DROP TABLE [formulaire_ecv];
GO
    DROP TABLE [formulaire_seo];
GO
    DROP TABLE [formulaire_sfa];
GO
    DROP TABLE [global_users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'appelant_medecins'
CREATE TABLE [appelant_medecins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Prenom] nvarchar(100)  NOT NULL,
    [Nom] nvarchar(100)  NOT NULL,
    [DateNaissance] datetime  NOT NULL,
    [Genre] bit  NOT NULL,
    [NumeroTelephonePortable] nvarchar(100)  NULL,
    [NumeroTelephoneFixe] nvarchar(100)  NULL,
    [Email] nvarchar(100)  NULL,
    [Adresse] nvarchar(100)  NULL,
    [TiersNom] nvarchar(100)  NULL,
    [TiersTelephone] nvarchar(100)  NULL,
    [TiersEmail] nvarchar(100)  NULL,
    [TiersLienParente] nvarchar(100)  NULL
);
GO

-- Creating table 'global_users'
CREATE TABLE [global_users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(100)  NOT NULL,
    [LastName] nvarchar(100)  NOT NULL,
    [Password] nvarchar(100)  NOT NULL,
    [Login] nvarchar(25)  NULL
);
GO

-- Creating table 'dossiers'
CREATE TABLE [dossiers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdMedecinAppelant] int  NOT NULL,
    [NumeroAnonymatGlobal] nvarchar(100)  NULL
);
GO

-- Creating table 'formulaire_act'
CREATE TABLE [formulaire_act] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdDossier] int  NOT NULL,
    [DtDebutEntretien] datetime  NULL,
    [DtFinEntretien] datetime  NULL,
    [Dt1ErContactMaAccueil] datetime  NULL,
    [Dt1ErContactMeMa] datetime  NULL,
    [DtMeAccueil] datetime  NULL,
    [Jour1ErContact] nvarchar(10)  NULL,
    [DepartementExerciceMa] nvarchar(100)  NULL,
    [SuggestionAppelMots] int  NULL,
    [AutreSuggestionAppelMots] nvarchar(100)  NULL,
    [DtCreation] datetime  NULL
);
GO

-- Creating table 'formulaire_cfp'
CREATE TABLE [formulaire_cfp] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdDossier] int  NOT NULL,
    [DtDebutEntretien] datetime  NULL,
    [DtFinEntretien] datetime  NULL,
    [StatutCivil] int  NULL,
    [RevenusSeulsFoyer] bit  NULL,
    [PersonnesACharge] bit  NULL,
    [GrossesseEnCours] bit  NULL,
    [ExerciceProfessionnel] int  NULL,
    [PrecisionsExerciceProfessionnel] int  NULL,
    [FonctionHospitaliere] int  NULL,
    [Specialite] int  NULL,
    [AutreMedecinTraitant] bit  NULL,
    [Automedication] bit  NULL,
    [SuiviDepistage] bit  NULL,
    [ActivitesLoisirs] nvarchar(100)  NULL,
    [PrevoyanceAssurance] bit  NULL,
    [CarmfAJour] bit  NULL,
    [UrssafAJour] bit  NULL,
    [OrdreMedecinAJour] bit  NULL,
    [DtCreation] datetime  NULL,
    [EnfantsMineurs] bit  NULL,
    [NombreHeuresHebdoMoyen] int  NULL,
    [CongesAnnuels] int  NULL,
    [ActivitesFormation] bit  NULL,
    [SavoirDireNon] bit  NULL,
    [NombreEnfantsMineurs] int  NULL
);
GO

-- Creating table 'formulaire_cda'
CREATE TABLE [formulaire_cda] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdDossier] int  NOT NULL,
    [DtDebutEntretien] datetime  NULL,
    [DtFinEntretien] datetime  NULL,
    [MotifAppelInitial] nvarchar(100)  NULL,
    [MotifAppelInitialAutre] nvarchar(100)  NULL,
    [ProblematiqueComplementaire] bit  NULL,
    [TypeProblematiqueComplementaire] nvarchar(100)  NULL,
    [TypeProblematiqueComplementaireAutre] nvarchar(100)  NULL,
    [Addictions] nvarchar(100)  NULL,
    [AntecedentsPersonnels] nvarchar(100)  NULL,
    [AntecedentsFamiliauxTa] bit  NULL,
    [DtCreation] datetime  NULL
);
GO

-- Creating table 'formulaire_ecv'
CREATE TABLE [formulaire_ecv] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdDossier] int  NOT NULL,
    [DtDebutEntretien] datetime  NULL,
    [DtFinEntretien] datetime  NULL,
    [DtEvaluation] datetime  NULL,
    [PriseTraitementPsychotrope] bit  NULL,
    [AutrePrescriptionPsychotropes] bit  NULL,
    [ContinuerPratiquerRythme] bit  NULL,
    [DtCreation] datetime  NULL
);
GO

-- Creating table 'formulaire_seo'
CREATE TABLE [formulaire_seo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdDossier] int  NOT NULL,
    [DtDebutEntretien] datetime  NULL,
    [DtFinEntretien] datetime  NULL,
    [NumeroEntretien] nvarchar(100)  NULL,
    [DateEntretien] datetime  NULL,
    [TypeEntretien] int  NULL,
    [DureeEntretien] int  NULL,
    [TravailConnexeEntretien] bit  NULL,
    [DureeDeplacement] int  NULL,
    [RechercheDocumentation] int  NULL,
    [ContactsExternesMots] int  NULL,
    [AutreTravailConnexe] nvarchar(100)  NULL,
    [AppelContactInterneMots] nvarchar(100)  NULL,
    [MotifAppelContactInterneMots] nvarchar(100)  NULL,
    [Orientations] nvarchar(100)  NULL,
    [OrientationAutre] nvarchar(100)  NULL,
    [ArretMaladiePreconise] bit  NULL,
    [DtCreation] datetime  NULL
);
GO

-- Creating table 'formulaire_sfa'
CREATE TABLE [formulaire_sfa] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdDossier] int  NOT NULL,
    [DtCreation] datetime  NULL,
    [DtDebutEntretien] datetime  NULL,
    [DtFinEntretien] datetime  NULL,
    [DateBilanSynthese] datetime  NULL,
    [DureeJourDepuis1ErContact] int  NULL,
    [NombreEntretiensDepuis1ErContact] int  NULL,
    [TempsTotalEnEntretiens] float  NULL,
    [OrientationsMisesEnOeuvre] nvarchar(100)  NULL,
    [OrientationsMisesEnOeuvreAutre] nvarchar(100)  NULL,
    [OrientationsIdentifiees1ErEntretien] nvarchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'appelant_medecins'
ALTER TABLE [appelant_medecins]
ADD CONSTRAINT [PK_appelant_medecins]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'global_users'
ALTER TABLE [global_users]
ADD CONSTRAINT [PK_global_users]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'dossiers'
ALTER TABLE [dossiers]
ADD CONSTRAINT [PK_dossiers]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'formulaire_act'
ALTER TABLE [formulaire_act]
ADD CONSTRAINT [PK_formulaire_act]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'formulaire_cfp'
ALTER TABLE [formulaire_cfp]
ADD CONSTRAINT [PK_formulaire_cfp]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'formulaire_cda'
ALTER TABLE [formulaire_cda]
ADD CONSTRAINT [PK_formulaire_cda]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'formulaire_ecv'
ALTER TABLE [formulaire_ecv]
ADD CONSTRAINT [PK_formulaire_ecv]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'formulaire_seo'
ALTER TABLE [formulaire_seo]
ADD CONSTRAINT [PK_formulaire_seo]
    PRIMARY KEY ([Id] );
GO

-- Creating primary key on [Id] in table 'formulaire_sfa'
ALTER TABLE [formulaire_sfa]
ADD CONSTRAINT [PK_formulaire_sfa]
    PRIMARY KEY ([Id] );
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdMedecinAppelant] in table 'dossiers'
ALTER TABLE [dossiers]
ADD CONSTRAINT [FK_MedecinAppelantId]
    FOREIGN KEY ([IdMedecinAppelant])
    REFERENCES [appelant_medecins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedecinAppelantId'
CREATE INDEX [IX_FK_MedecinAppelantId]
ON [dossiers]
    ([IdMedecinAppelant]);
GO

-- Creating foreign key on [IdDossier] in table 'formulaire_act'
ALTER TABLE [formulaire_act]
ADD CONSTRAINT [FK_IdDossier]
    FOREIGN KEY ([IdDossier])
    REFERENCES [dossiers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdDossier'
CREATE INDEX [IX_FK_IdDossier]
ON [formulaire_act]
    ([IdDossier]);
GO

-- Creating foreign key on [IdDossier] in table 'formulaire_cfp'
ALTER TABLE [formulaire_cfp]
ADD CONSTRAINT [FK_IdDossier_Cfp]
    FOREIGN KEY ([IdDossier])
    REFERENCES [dossiers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdDossier_Cfp'
CREATE INDEX [IX_FK_IdDossier_Cfp]
ON [formulaire_cfp]
    ([IdDossier]);
GO

-- Creating foreign key on [IdDossier] in table 'formulaire_cda'
ALTER TABLE [formulaire_cda]
ADD CONSTRAINT [FK_IdDossier_Cda]
    FOREIGN KEY ([IdDossier])
    REFERENCES [dossiers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdDossier_Cda'
CREATE INDEX [IX_FK_IdDossier_Cda]
ON [formulaire_cda]
    ([IdDossier]);
GO

-- Creating foreign key on [IdDossier] in table 'formulaire_ecv'
ALTER TABLE [formulaire_ecv]
ADD CONSTRAINT [FK_IdDossier_Ecv]
    FOREIGN KEY ([IdDossier])
    REFERENCES [dossiers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdDossier_Ecv'
CREATE INDEX [IX_FK_IdDossier_Ecv]
ON [formulaire_ecv]
    ([IdDossier]);
GO

-- Creating foreign key on [IdDossier] in table 'formulaire_seo'
ALTER TABLE [formulaire_seo]
ADD CONSTRAINT [FK_IdDossier_Seo]
    FOREIGN KEY ([IdDossier])
    REFERENCES [dossiers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdDossier_Seo'
CREATE INDEX [IX_FK_IdDossier_Seo]
ON [formulaire_seo]
    ([IdDossier]);
GO

-- Creating foreign key on [IdDossier] in table 'formulaire_sfa'
ALTER TABLE [formulaire_sfa]
ADD CONSTRAINT [FK_IdDossier_Sfa]
    FOREIGN KEY ([IdDossier])
    REFERENCES [dossiers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdDossier_Sfa'
CREATE INDEX [IX_FK_IdDossier_Sfa]
ON [formulaire_sfa]
    ([IdDossier]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------