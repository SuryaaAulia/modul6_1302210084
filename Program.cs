using tpmodul6_1302210084;

SayaTubeUser su = new SayaTubeUser("Review video ESL csgo  oleh SURYA AULIA");
SayaTubeVideo sv = new SayaTubeVideo("FaZe vs Cloud9 - ESL Pro League Season 17 - GRAND FINAL ");
SayaTubeVideo sv1 = new SayaTubeVideo("FaZe vs ENCE - ESL Pro League Season 16 - GRAND FINAL ");
SayaTubeVideo sv2 = new SayaTubeVideo("TSM vs Liquid - ESL Pro League Season 15 - GRAND FINAL ");
SayaTubeVideo sv3 = new SayaTubeVideo("G2 vs NaVi - ESL Pro League Season 14 - GRAND FINAL ");
SayaTubeVideo sv4 = new SayaTubeVideo("Vatality vs Astralis - ESL Pro League Season 13 - GRAND FINAL ");
SayaTubeVideo sv5 = new SayaTubeVideo("Fnatic vs Evil Genius - ESL Pro League Season 12 - GRAND FINAL ");
SayaTubeVideo sv6 = new SayaTubeVideo("Apex vs Cloud9 - ESL Pro League Season 11 - GRAND FINAL ");
SayaTubeVideo sv7 = new SayaTubeVideo("FaZe vs 100T - ESL Pro League Season 10 - GRAND FINAL ");
SayaTubeVideo sv8 = new SayaTubeVideo("Vatality vs MouseFit - ESL Pro League Season 9 - GRAND FINAL ");
SayaTubeVideo sv9 = new SayaTubeVideo("NaVi vs ENCE - ESL Pro League Season 8 - GRAND FINAL ");

sv.IncreasePlayCount(100000000);
su.AddVideo(sv);
su.AddVideo(sv1);
su.AddVideo(sv2);
su.AddVideo(sv3);
su.AddVideo(sv4);
su.AddVideo(sv5);
su.AddVideo(sv6);
su.AddVideo(sv7);
su.AddVideo(sv8);
su.AddVideo(sv9);
su.PrintAllVideoPlaycount();