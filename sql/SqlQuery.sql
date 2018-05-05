﻿CREATE TABLE [dbo].[Customers] (
    [Id] [int] NOT NULL IDENTITY,
    [Name] [varchar](30) NOT NULL,
    [LastName] [varchar](100) NOT NULL,
    [CPF] [varchar](11) NOT NULL,
    [Birthday] [datetime] NOT NULL,
    [Age] [int] NOT NULL,
    [OccupationId] [int],
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Occupations] (
    [Id] [int] NOT NULL IDENTITY,
    [Description] [varchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.Occupations] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_OccupationId] ON [dbo].[Customers]([OccupationId])
ALTER TABLE [dbo].[Customers] ADD CONSTRAINT [FK_dbo.Customers_dbo.Occupations_OccupationId] FOREIGN KEY ([OccupationId]) REFERENCES [dbo].[Occupations] ([Id])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201805052203470_AutomaticMigration', N'Fate.BackEnd.Infra.Migrations.Configuration',  0x1F8B0800000000000400ED59DB6EE336107D2FD07F10F458642D3BFBD206F62E12272E826E2E889345DF02461A3BC452944A52818D45BFAC0FFDA4FE4287BA52D4C58A932CDAA2586091509C33179E19CE307FFDF1E7F4E32664CE130849233E7327A3B1EB00F7A380F2F5CC4DD4EADD8FEEC70FDF7F373D0BC28DF3B9D8F75EEF43492E67EEA352F191E749FF1142224721F54524A3951AF951E89120F20EC7E39FBCC9C403847011CB71A63709573484F417FC751E711F629510761105C064BE8E5F9629AA7349429031F161E62E8882D109F1BF9CF16074CE57828C505CC146B9CE31A3042D5A025BB90EE13C5244A1BD477712964A447CBD8C7181B0DB6D0CB86F459884DC8FA36AFB5097C687DA25AF122CA0FC44AA287C26E0E47D1E23CF16DF2BD26E19438CE219465B6DB5D7692467EE3C5501C2756C65477326F4462BD0A7B887F251763CA342FCC069D97450D204D9A4FF1D38F384A944C08C43A2046107CE75F2C0A8FF0B6C6FA32FC0673C61CC34184DC66FB5055CBA16510C426D6F6095BB711EB88E5797F36CC152CC90C91C3CE7EAFDA1EB5CA272F2C0A0E483118CA58A04FC0C1C04FA195C13A540708D0169441BDA2D5DFAFF421B121073CA752EC8E613F0B57AC42CC2245AD00D04C5426EC01DA7988128A344022D06F62BFD44A4DAA178327E13CDF3EB459FD289A533D3F132952754A8C7806C0BBDA7784EB7347C3ED0F11A76F1A21FE0CAF79338654D836196E02579A2EB74672784EBDC004B7F928F34CE2A5A9975F7E6BE8588C29B8819396D7CBE5F4689F0B56351F79E5B22D6A0EA564EBDAA64F41612D394BD4A4905F07F31E927D829485FD0388BF5DBA676D7F11F4B19F934F5C6BA484C4ED6BDC0B374061034F3C7A439BA85274D633C5B3465E6FED008503F74C16B03DA646B1D7C3C1A4D1AF8C80D10FA7008C3164322DB28574D2251EED398B0DDA658A20359A88FA354627F398518B826D0EE180FD15E2F624D3B4A75569EEC8AD4D433A8D32C28BA814309104510745B5776758DBA82ED5C5E5A644E679B171A7409CA22A9749D8AD70DB635C85507A942D3066332CB02323C6F9A54ABE5C6CE9E926F1FCAB0042BDDA985A371C2C352CA00AB85C52E9F75D75B0A4C79F055C7EF652D7F311A781DB3C1F482C431163F6356C8579C653628CCDF2D9FDF39871986E7CB9606BAB4B6D484159DACC1FA8AAAD1D2051552613B421E882EAFF3206C6CABD1BC837D852A9BC9CD832B185948E89F33A9EE91A9A27FB33AE4380BF430D40526BDBE5A68D4144DE736C28868B92DE7114B42DE5DEBBAA5B39ED694CF568623549DB18952AD0E474A3B5D13245D182E5FB5AD2648B53A1C29ED5B4D907461B87CBDE29B40FD77814E4D8B218DDBA2C149AB3CD8241F940266C179A524E82EAE03D2A04FF86D12A1D6089A30B50FDFF8C01A15DDDE526A2F2BBB55C1A77935DDFD04D428AFD916D7C1403DD14097D6E5562A08477AC368F91B9B338AFE561B2E08A72B902A9B18DCC3F1E4D07A3DFAE7BCE47852066CEFE79C736CD73633F7ABF3FBB79F89A80EF9CEA9E79973B6F9B4F14484FF4844E351E5852F266DB0E95CB5FF7B482BE4E4C5CF1D01C654BDF0B9233DA55778EC4871BAF9A7058F9CF35FEF4DD903E74A603A1E3963E4A7614436A3BEFE8BC47F2E1B5A1E05F663EFDB8CFCE661EC3F873787923D1F0CF61AE87BBB83371BE0FF4DE37A73DC19368FF78EE3D99D8E25EE21C2D3CE78DB39B9F64CEB3B86F536357D33EDB79BE69B2ED8FDE690F1BD75F27F9B49BDD9BF21D38C3FF421D7255D5710FACF7E1CFC1AC7CA3DD8A14705E12D8B8A2D5629BC0045F03E24C742D115F1157EF641CAF481F43361096E390B1F2038E757898A13852E43F8C06AD3964E993EFDE97344DDE6E9555A7DE56BB88066527DA55FF19384B2A0B47BD152AF3B20742EE6F78B3E4BA5EF99F5B644BA8CF840A03C7C6509B98530660826AFF8923CC13EB6DD49F8046BE26F8B36BC1B64F741D4C33E3DA5642D4828738C4A1E7F450E07E1E6C3DFA000831CEF1E0000 , N'6.2.0-61023')

