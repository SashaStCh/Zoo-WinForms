
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2021 16:58:15
-- Generated from EDMX file: C:\Users\sasha\Desktop\ZooSQL\ZooSQL\ZooModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Zoo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FoodSet'
CREATE TABLE [dbo].[FoodSet] (
    [food_name] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'Food_RationSet'
CREATE TABLE [dbo].[Food_RationSet] (
    [Id] int  NOT NULL,
    [Food_food_name] nvarchar(200)  NOT NULL,
    [Speties_species_name] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'SpetiesSet'
CREATE TABLE [dbo].[SpetiesSet] (
    [species_name] nvarchar(200)  NOT NULL,
    [name_in_latin] nvarchar(200)  NOT NULL,
    [description] nvarchar(max)  NULL
);
GO

-- Creating table 'Feeding_TimeSet'
CREATE TABLE [dbo].[Feeding_TimeSet] (
    [f_time] datetime  NOT NULL,
    [Food_food_name] nvarchar(200)  NOT NULL,
    [Animal_animal_code] int  NOT NULL,
    [Employee_emp_code] int  NOT NULL
);
GO

-- Creating table 'AnimalSet'
CREATE TABLE [dbo].[AnimalSet] (
    [animal_code] int IDENTITY(1,1) NOT NULL,
    [animal_name] nvarchar(200)  NOT NULL,
    [animal_gender] nvarchar(1)  NOT NULL,
    [color] nvarchar(200)  NULL,
    [date_of_birth] datetime  NOT NULL,
    [Speties_species_name] nvarchar(200)  NOT NULL,
    [Aviary_aviary_code] int  NOT NULL
);
GO

-- Creating table 'AviarySet'
CREATE TABLE [dbo].[AviarySet] (
    [aviary_code] int IDENTITY(1,1) NOT NULL,
    [aviary_type] nvarchar(200)  NULL,
    [area] int  NULL
);
GO

-- Creating table 'Health_StatusSet'
CREATE TABLE [dbo].[Health_StatusSet] (
    [h_status] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'Animal_AnalysisSet'
CREATE TABLE [dbo].[Animal_AnalysisSet] (
    [analysis_code] int IDENTITY(1,1) NOT NULL,
    [analysis_date] datetime  NOT NULL,
    [weight] int  NOT NULL,
    [Animal_animal_code] int  NOT NULL,
    [Health_Status_h_status] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'Zoo_InformationSet'
CREATE TABLE [dbo].[Zoo_InformationSet] (
    [zoo_name] nvarchar(200)  NOT NULL,
    [address] nvarchar(200)  NOT NULL,
    [zoo_area] int  NOT NULL,
    [opening_time] datetime  NOT NULL,
    [closing_time] datetime  NOT NULL,
    [hotline_phone] nvarchar(10)  NOT NULL,
    [zoo_history] nvarchar(max)  NULL
);
GO

-- Creating table 'AuthorizationSet'
CREATE TABLE [dbo].[AuthorizationSet] (
    [login] nvarchar(32)  NOT NULL,
    [password] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'EmployeeSet'
CREATE TABLE [dbo].[EmployeeSet] (
    [emp_code] int IDENTITY(1,1) NOT NULL,
    [last_name] nvarchar(200)  NOT NULL,
    [first_name] nvarchar(200)  NOT NULL,
    [patronymic] nvarchar(200)  NULL,
    [emp_gender] nvarchar(1)  NOT NULL,
    [salary] decimal(15,2)  NOT NULL,
    [phone_number] nvarchar(10)  NOT NULL,
    [address] nvarchar(200)  NOT NULL,
    [email] nvarchar(200)  NULL,
    [start_schedule] time  NOT NULL,
    [finish_schedule] time  NOT NULL,
    [Job_job_id] int  NOT NULL
);
GO

-- Creating table 'History_Work_ShiftSet'
CREATE TABLE [dbo].[History_Work_ShiftSet] (
    [time_a_l] datetime  NOT NULL,
    [Employee_emp_code] int  NOT NULL,
    [Work_Shift_arrival_leaving] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Work_ShiftSet'
CREATE TABLE [dbo].[Work_ShiftSet] (
    [arrival_leaving] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Cashbox_StatusSet'
CREATE TABLE [dbo].[Cashbox_StatusSet] (
    [status_name] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'Status_ChangesSet'
CREATE TABLE [dbo].[Status_ChangesSet] (
    [status_date] datetime  NOT NULL,
    [Employee_emp_code] int  NOT NULL,
    [Cashbox_Status_status_name] nvarchar(200)  NOT NULL,
    [Cashbox_cashbox_code] int  NOT NULL
);
GO

-- Creating table 'CashboxSet'
CREATE TABLE [dbo].[CashboxSet] (
    [cashbox_code] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'TicketSet'
CREATE TABLE [dbo].[TicketSet] (
    [ticket_code] int IDENTITY(1,1) NOT NULL,
    [date_of_purchase] datetime  NOT NULL,
    [Cashbox_cashbox_code] int  NOT NULL,
    [Ticket_Type_t_type] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Ticket_TypeSet'
CREATE TABLE [dbo].[Ticket_TypeSet] (
    [t_type] nvarchar(32)  NOT NULL,
    [price] decimal(15,2)  NOT NULL
);
GO

-- Creating table 'JobSet'
CREATE TABLE [dbo].[JobSet] (
    [job_id] int IDENTITY(1,1) NOT NULL,
    [job_name] nvarchar(200)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [food_name] in table 'FoodSet'
ALTER TABLE [dbo].[FoodSet]
ADD CONSTRAINT [PK_FoodSet]
    PRIMARY KEY CLUSTERED ([food_name] ASC);
GO

-- Creating primary key on [Id] in table 'Food_RationSet'
ALTER TABLE [dbo].[Food_RationSet]
ADD CONSTRAINT [PK_Food_RationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [species_name] in table 'SpetiesSet'
ALTER TABLE [dbo].[SpetiesSet]
ADD CONSTRAINT [PK_SpetiesSet]
    PRIMARY KEY CLUSTERED ([species_name] ASC);
GO

-- Creating primary key on [f_time] in table 'Feeding_TimeSet'
ALTER TABLE [dbo].[Feeding_TimeSet]
ADD CONSTRAINT [PK_Feeding_TimeSet]
    PRIMARY KEY CLUSTERED ([f_time] ASC);
GO

-- Creating primary key on [animal_code] in table 'AnimalSet'
ALTER TABLE [dbo].[AnimalSet]
ADD CONSTRAINT [PK_AnimalSet]
    PRIMARY KEY CLUSTERED ([animal_code] ASC);
GO

-- Creating primary key on [aviary_code] in table 'AviarySet'
ALTER TABLE [dbo].[AviarySet]
ADD CONSTRAINT [PK_AviarySet]
    PRIMARY KEY CLUSTERED ([aviary_code] ASC);
GO

-- Creating primary key on [h_status] in table 'Health_StatusSet'
ALTER TABLE [dbo].[Health_StatusSet]
ADD CONSTRAINT [PK_Health_StatusSet]
    PRIMARY KEY CLUSTERED ([h_status] ASC);
GO

-- Creating primary key on [analysis_code] in table 'Animal_AnalysisSet'
ALTER TABLE [dbo].[Animal_AnalysisSet]
ADD CONSTRAINT [PK_Animal_AnalysisSet]
    PRIMARY KEY CLUSTERED ([analysis_code] ASC);
GO

-- Creating primary key on [zoo_name] in table 'Zoo_InformationSet'
ALTER TABLE [dbo].[Zoo_InformationSet]
ADD CONSTRAINT [PK_Zoo_InformationSet]
    PRIMARY KEY CLUSTERED ([zoo_name] ASC);
GO

-- Creating primary key on [login] in table 'AuthorizationSet'
ALTER TABLE [dbo].[AuthorizationSet]
ADD CONSTRAINT [PK_AuthorizationSet]
    PRIMARY KEY CLUSTERED ([login] ASC);
GO

-- Creating primary key on [emp_code] in table 'EmployeeSet'
ALTER TABLE [dbo].[EmployeeSet]
ADD CONSTRAINT [PK_EmployeeSet]
    PRIMARY KEY CLUSTERED ([emp_code] ASC);
GO

-- Creating primary key on [time_a_l] in table 'History_Work_ShiftSet'
ALTER TABLE [dbo].[History_Work_ShiftSet]
ADD CONSTRAINT [PK_History_Work_ShiftSet]
    PRIMARY KEY CLUSTERED ([time_a_l] ASC);
GO

-- Creating primary key on [arrival_leaving] in table 'Work_ShiftSet'
ALTER TABLE [dbo].[Work_ShiftSet]
ADD CONSTRAINT [PK_Work_ShiftSet]
    PRIMARY KEY CLUSTERED ([arrival_leaving] ASC);
GO

-- Creating primary key on [status_name] in table 'Cashbox_StatusSet'
ALTER TABLE [dbo].[Cashbox_StatusSet]
ADD CONSTRAINT [PK_Cashbox_StatusSet]
    PRIMARY KEY CLUSTERED ([status_name] ASC);
GO

-- Creating primary key on [status_date] in table 'Status_ChangesSet'
ALTER TABLE [dbo].[Status_ChangesSet]
ADD CONSTRAINT [PK_Status_ChangesSet]
    PRIMARY KEY CLUSTERED ([status_date] ASC);
GO

-- Creating primary key on [cashbox_code] in table 'CashboxSet'
ALTER TABLE [dbo].[CashboxSet]
ADD CONSTRAINT [PK_CashboxSet]
    PRIMARY KEY CLUSTERED ([cashbox_code] ASC);
GO

-- Creating primary key on [ticket_code] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [PK_TicketSet]
    PRIMARY KEY CLUSTERED ([ticket_code] ASC);
GO

-- Creating primary key on [t_type] in table 'Ticket_TypeSet'
ALTER TABLE [dbo].[Ticket_TypeSet]
ADD CONSTRAINT [PK_Ticket_TypeSet]
    PRIMARY KEY CLUSTERED ([t_type] ASC);
GO

-- Creating primary key on [job_id] in table 'JobSet'
ALTER TABLE [dbo].[JobSet]
ADD CONSTRAINT [PK_JobSet]
    PRIMARY KEY CLUSTERED ([job_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Food_food_name] in table 'Feeding_TimeSet'
ALTER TABLE [dbo].[Feeding_TimeSet]
ADD CONSTRAINT [FK_FoodFeeding_Time]
    FOREIGN KEY ([Food_food_name])
    REFERENCES [dbo].[FoodSet]
        ([food_name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FoodFeeding_Time'
CREATE INDEX [IX_FK_FoodFeeding_Time]
ON [dbo].[Feeding_TimeSet]
    ([Food_food_name]);
GO

-- Creating foreign key on [Food_food_name] in table 'Food_RationSet'
ALTER TABLE [dbo].[Food_RationSet]
ADD CONSTRAINT [FK_FoodFood_Ration]
    FOREIGN KEY ([Food_food_name])
    REFERENCES [dbo].[FoodSet]
        ([food_name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FoodFood_Ration'
CREATE INDEX [IX_FK_FoodFood_Ration]
ON [dbo].[Food_RationSet]
    ([Food_food_name]);
GO

-- Creating foreign key on [Speties_species_name] in table 'Food_RationSet'
ALTER TABLE [dbo].[Food_RationSet]
ADD CONSTRAINT [FK_SpetiesFood_Ration]
    FOREIGN KEY ([Speties_species_name])
    REFERENCES [dbo].[SpetiesSet]
        ([species_name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SpetiesFood_Ration'
CREATE INDEX [IX_FK_SpetiesFood_Ration]
ON [dbo].[Food_RationSet]
    ([Speties_species_name]);
GO

-- Creating foreign key on [Speties_species_name] in table 'AnimalSet'
ALTER TABLE [dbo].[AnimalSet]
ADD CONSTRAINT [FK_SpetiesAnimal]
    FOREIGN KEY ([Speties_species_name])
    REFERENCES [dbo].[SpetiesSet]
        ([species_name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SpetiesAnimal'
CREATE INDEX [IX_FK_SpetiesAnimal]
ON [dbo].[AnimalSet]
    ([Speties_species_name]);
GO

-- Creating foreign key on [Aviary_aviary_code] in table 'AnimalSet'
ALTER TABLE [dbo].[AnimalSet]
ADD CONSTRAINT [FK_AviaryAnimal]
    FOREIGN KEY ([Aviary_aviary_code])
    REFERENCES [dbo].[AviarySet]
        ([aviary_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AviaryAnimal'
CREATE INDEX [IX_FK_AviaryAnimal]
ON [dbo].[AnimalSet]
    ([Aviary_aviary_code]);
GO

-- Creating foreign key on [Animal_animal_code] in table 'Feeding_TimeSet'
ALTER TABLE [dbo].[Feeding_TimeSet]
ADD CONSTRAINT [FK_AnimalFeeding_Time]
    FOREIGN KEY ([Animal_animal_code])
    REFERENCES [dbo].[AnimalSet]
        ([animal_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimalFeeding_Time'
CREATE INDEX [IX_FK_AnimalFeeding_Time]
ON [dbo].[Feeding_TimeSet]
    ([Animal_animal_code]);
GO

-- Creating foreign key on [Animal_animal_code] in table 'Animal_AnalysisSet'
ALTER TABLE [dbo].[Animal_AnalysisSet]
ADD CONSTRAINT [FK_AnimalAnimal_Analysis]
    FOREIGN KEY ([Animal_animal_code])
    REFERENCES [dbo].[AnimalSet]
        ([animal_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimalAnimal_Analysis'
CREATE INDEX [IX_FK_AnimalAnimal_Analysis]
ON [dbo].[Animal_AnalysisSet]
    ([Animal_animal_code]);
GO

-- Creating foreign key on [Health_Status_h_status] in table 'Animal_AnalysisSet'
ALTER TABLE [dbo].[Animal_AnalysisSet]
ADD CONSTRAINT [FK_Health_StatusAnimal_Analysis]
    FOREIGN KEY ([Health_Status_h_status])
    REFERENCES [dbo].[Health_StatusSet]
        ([h_status])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Health_StatusAnimal_Analysis'
CREATE INDEX [IX_FK_Health_StatusAnimal_Analysis]
ON [dbo].[Animal_AnalysisSet]
    ([Health_Status_h_status]);
GO

-- Creating foreign key on [Employee_emp_code] in table 'Feeding_TimeSet'
ALTER TABLE [dbo].[Feeding_TimeSet]
ADD CONSTRAINT [FK_EmployeeFeeding_Time]
    FOREIGN KEY ([Employee_emp_code])
    REFERENCES [dbo].[EmployeeSet]
        ([emp_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeFeeding_Time'
CREATE INDEX [IX_FK_EmployeeFeeding_Time]
ON [dbo].[Feeding_TimeSet]
    ([Employee_emp_code]);
GO

-- Creating foreign key on [Job_job_id] in table 'EmployeeSet'
ALTER TABLE [dbo].[EmployeeSet]
ADD CONSTRAINT [FK_JobEmployee]
    FOREIGN KEY ([Job_job_id])
    REFERENCES [dbo].[JobSet]
        ([job_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobEmployee'
CREATE INDEX [IX_FK_JobEmployee]
ON [dbo].[EmployeeSet]
    ([Job_job_id]);
GO

-- Creating foreign key on [Employee_emp_code] in table 'History_Work_ShiftSet'
ALTER TABLE [dbo].[History_Work_ShiftSet]
ADD CONSTRAINT [FK_EmployeeHistory_Work_Shift]
    FOREIGN KEY ([Employee_emp_code])
    REFERENCES [dbo].[EmployeeSet]
        ([emp_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeHistory_Work_Shift'
CREATE INDEX [IX_FK_EmployeeHistory_Work_Shift]
ON [dbo].[History_Work_ShiftSet]
    ([Employee_emp_code]);
GO

-- Creating foreign key on [Work_Shift_arrival_leaving] in table 'History_Work_ShiftSet'
ALTER TABLE [dbo].[History_Work_ShiftSet]
ADD CONSTRAINT [FK_Work_ShiftHistory_Work_Shift]
    FOREIGN KEY ([Work_Shift_arrival_leaving])
    REFERENCES [dbo].[Work_ShiftSet]
        ([arrival_leaving])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Work_ShiftHistory_Work_Shift'
CREATE INDEX [IX_FK_Work_ShiftHistory_Work_Shift]
ON [dbo].[History_Work_ShiftSet]
    ([Work_Shift_arrival_leaving]);
GO

-- Creating foreign key on [Employee_emp_code] in table 'Status_ChangesSet'
ALTER TABLE [dbo].[Status_ChangesSet]
ADD CONSTRAINT [FK_EmployeeStatus_Changes]
    FOREIGN KEY ([Employee_emp_code])
    REFERENCES [dbo].[EmployeeSet]
        ([emp_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeStatus_Changes'
CREATE INDEX [IX_FK_EmployeeStatus_Changes]
ON [dbo].[Status_ChangesSet]
    ([Employee_emp_code]);
GO

-- Creating foreign key on [Cashbox_Status_status_name] in table 'Status_ChangesSet'
ALTER TABLE [dbo].[Status_ChangesSet]
ADD CONSTRAINT [FK_Cashbox_StatusStatus_Changes]
    FOREIGN KEY ([Cashbox_Status_status_name])
    REFERENCES [dbo].[Cashbox_StatusSet]
        ([status_name])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Cashbox_StatusStatus_Changes'
CREATE INDEX [IX_FK_Cashbox_StatusStatus_Changes]
ON [dbo].[Status_ChangesSet]
    ([Cashbox_Status_status_name]);
GO

-- Creating foreign key on [Cashbox_cashbox_code] in table 'Status_ChangesSet'
ALTER TABLE [dbo].[Status_ChangesSet]
ADD CONSTRAINT [FK_CashboxStatus_Changes]
    FOREIGN KEY ([Cashbox_cashbox_code])
    REFERENCES [dbo].[CashboxSet]
        ([cashbox_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CashboxStatus_Changes'
CREATE INDEX [IX_FK_CashboxStatus_Changes]
ON [dbo].[Status_ChangesSet]
    ([Cashbox_cashbox_code]);
GO

-- Creating foreign key on [Cashbox_cashbox_code] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_CashboxTicket]
    FOREIGN KEY ([Cashbox_cashbox_code])
    REFERENCES [dbo].[CashboxSet]
        ([cashbox_code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CashboxTicket'
CREATE INDEX [IX_FK_CashboxTicket]
ON [dbo].[TicketSet]
    ([Cashbox_cashbox_code]);
GO

-- Creating foreign key on [Ticket_Type_t_type] in table 'TicketSet'
ALTER TABLE [dbo].[TicketSet]
ADD CONSTRAINT [FK_Ticket_TypeTicket]
    FOREIGN KEY ([Ticket_Type_t_type])
    REFERENCES [dbo].[Ticket_TypeSet]
        ([t_type])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ticket_TypeTicket'
CREATE INDEX [IX_FK_Ticket_TypeTicket]
ON [dbo].[TicketSet]
    ([Ticket_Type_t_type]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------