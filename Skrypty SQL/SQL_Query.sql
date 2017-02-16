drop table GAL.GAL_Ustawienia;
drop table GAL.GAL_Bledy;
drop table GAL.GAL_TrnKoment;
drop table GAL.GAL_Operatorzy;
drop table GAL.GAL_Dzialy;
drop table GAL.GAL_Statusy;

/* Kolejnoœæ tworzenia tabel:
	- Zlecenia 
		- Opis Zlecenia 
	- Zlecenia elementy
		- Opis Elementu
	- Zlecenia subelementy
		- Statusy subelementów
	- Operatorzy
		- Stanowiska
		- Dzia³y
*/

CREATE TABLE GAL.GAL_Statusy
(
	STT_SttId int NOT NULL identity(1,1),
	STT_Nazwa varchar(255) NOT NULL,
	STT_DataDodania date NOT NULL,
	STT_Archiwalny varchar(255) NOT NULL,
	PRIMARY KEY (STT_SttId)
);
insert into GAL.GAL_Statusy values('Przyjêto zamówienie', getdate(),0);
insert into GAL.GAL_Statusy values('Archiwalny', getdate(),1);


CREATE TABLE GAL.GAL_Dzialy
(
	DZI_DziId int NOT NULL identity(1,1),
	DZI_Nazwa varchar(255) NOT NULL,
	DZI_DataDodania date NOT NULL,
	DZI_Archiwalny varchar(255) NOT NULL,
	PRIMARY KEY (DZI_DziId)
);
insert into GAL.GAL_Dzialy values('Lakiernia', getdate(),0);
insert into GAL.GAL_Dzialy values('Archiwalny', getdate(),1);


CREATE TABLE GAL.GAL_Operatorzy
(
	OPR_OprId int NOT NULL identity(1,1),
	OPR_Imie varchar(255) NOT NULL,
	OPR_Nazwisko varchar(255) NOT NULL,
	OPR_Haslo varchar(255) NOT NULL,
	OPR_Dzial int NOT NULL,
	OPR_Uprawnienia smallint NOT NULL,
	OPR_Archiwalny smallint not null,
	PRIMARY KEY (OPR_OprId),
	FOREIGN KEY (OPR_Dzial) REFERENCES GAL.GAL_Dzialy(DZI_DziId)
);
insert into GAL.GAL_Operatorzy values('Galsoft', 'RB', '', 1, 0, 0);

CREATE TABLE GAL.GAL_Ustawienia
(
	UST_UstId int IDENTITY(1,1) NOT NULL,
	UST_Parametr varchar(1000) NOT NULL,
	UST_Wartosc varchar(1000) NOT NULL,
	UST_OprId int NOT NULL,
	UST_DataDodania datetime NOT NULL
	PRIMARY KEY (UST_UstId),
	FOREIGN KEY (UST_OprId) REFERENCES GAL.GAL_Operatorzy(OPR_OprId)
);

insert into GAL.GAL_Ustawienia values('WersjaAplikacji', '0.1', 1, '1999-12-31 00:00:00.000');

CREATE TABLE GAL.GAL_Bledy
(
	BLE_BleId int IDENTITY(1,1) NOT NULL,
	BLE_Modul varchar(1000) NOT NULL,
	BLE_Blad varchar(1000) NOT NULL,
	BLE_OprId int NOT NULL,
	BLE_DataDodania datetime NOT NULL
	PRIMARY KEY (BLE_BleId),
	FOREIGN KEY (BLE_OprId) REFERENCES GAL.GAL_Operatorzy(OPR_OprId)
);

CREATE TABLE GAL.GAL_TrnKoment
(
	TRK_TrkId int IDENTITY(1,1) NOT NULL,
	TRK_TrNID int NOT NULL,
	TRK_Tresc varchar(1000) NOT NULL,
	TRK_OprId int NOT NULL,
	TRK_DataDodania datetime NOT NULL
	PRIMARY KEY (TRK_TrkId),
	FOREIGN KEY (TRK_OprId) REFERENCES GAL.GAL_Operatorzy(OPR_OprId)
);


