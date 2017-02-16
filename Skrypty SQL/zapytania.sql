/* zwraca listê rezerwacji odbiorcy */
select trn.Trn_TrNID, trn.TrN_PodmiotTyp, trn.TrN_PodID, trn.Trn_NumerPelny, trn.Trn_PodNazwa1, trn.Trn_DataDok, trn.Trn_DataWys,*, trk.TRK_Tresc from CDN_Meble_Produkcja.cdn.tranag trn left join GAL_ZamowMebel.GAL.GAL_TrnKoment trk on trk.TRK_TrNID = trn.trn_TrNID where TrN_TypDokumentu = 308;

/* zwraca listê rezerwacji odbiorcy z parametrami*/
select trn.Trn_TrNID, trn.TrN_PodmiotTyp, trn.TrN_PodID, trn.Trn_NumerPelny, trn.Trn_PodNazwa1, trn.Trn_DataDok, trn.Trn_DataWys, trk.TRK_Tresc from CDN_Meble_Produkcja.cdn.tranag trn left join GAL_ZamowMebel.GAL.GAL_TrnKoment trk on trk.TRK_TrNID = trn.trn_TrNID where trn.TrN_TypDokumentu = 308 and (Trn_DataWys BETWEEN '2017-02-15' and '2017-02-15');

/* zwraca listê kontrahentów z rezerwacji odbiorcy */
select '<wszyscy>' as Trn_PodNazwa1,-1 as trn_Podmiottyp,-1 as trn_podid union select distinct(Trn_PodNazwa1), trn_Podmiottyp, trn_podid from CDN_Meble_Produkcja.cdn.tranag  where TrN_TypDokumentu = 308;

/* zwraca dane kontrahenta */
select Pod_PodID, Pod_PodmiotTyp, Pod_Kod, Pod_Nazwa1, Pod_Wojewodztwo, Pod_Ulica, Pod_Miasto, Pod_KodPocztowy, Pod_Telefon1, Pod_NIP from CDN_Meble_Produkcja.cdn.PodmiotyView where PoD_PodmiotTyp = 1 and Pod_PodID = 2;

/* zwraca pozycje dokumentu */
select TrE_TrEID, TrE_Lp, TrE_TwrId, TrE_TwrNazwa, TrE_TwrKod, TrE_Ilosc, TrE_Jm from CDN_Meble_Produkcja.cdn.TraElem where TrE_TrNId = 1





































