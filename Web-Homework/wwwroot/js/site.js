// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(document).ready(function () {

    var arrLang = {

        'tr': {
            '0': 'Giriş Yap',
            '1': 'Merhaba!',
            '2': 'Çıkış Yap',
            '3': 'Ana Sayfa',
            '4': 'Duyurular',
            '5': 'Galeri',
            '6': 'Aktiviteler',
            '7': 'İletişim',
            '8': 'Merhaba Admin!',
            '9': 'Rol Paneli',
            '10': 'Kişiler Paneli',
            '11': 'Rol Listesi',
            '12': 'Rol Adı',
            '13': 'Sil',
            '14': 'Güncelle',
            '15': 'Yeni Rol Ekle',
            '16': 'Rol Ekleme Sayfası',
            '17': 'Rol Açıklaması',
            '18': 'Kaydet',
            '19': 'Kişiler Listesi',
            '20': 'Fotoğraf',
            '21': 'Kişi Adı',
            '22': 'Kişi Soyadı',
            '23': 'Kişi Telefonu',
            '24': "Kişi Email'i",
            '25': 'Yeni Kişi Ekle',
            '26': 'Kişi Güncelleme Sayfası',
            '27': 'Kişi Ekleme Sayfası',
            '28': "Gençlik ve Spor Bakanı Kasapoğlu'ndan Burs/ Kredi Müjdesi",
            '29': 'Burs/kredi başvuru süresi uzatıldı. Daha önce başvurularını gerçekleştirme fırsatı bulamayan gençler, başvurularını 26 Kasım Cumartesi günü saat 23.59’a kadar e-Devlet üzerinden yapabilecek.',
            '30': "Gençler Konya’da Buluşuyor",
            '31': 'Günübirlik gerçekleştirilecek gezide Şems-i Tebrizi Türbesi/Camii, Şerafettin Camii, İplikçi Camii, Mevlana Türbe ve Müzesi, Kelebekler Vadisi, Şehitlik, Alaaddin Tepesi/Camii, Aziziye Camii gibi tarihi ve kültürel mekânlar ziyaret edilecek.',
            '32': 'Bakan Kasapoğlu Duyurdu: GSB Burs/Öğrenim Kredisi Sonuçları Açıklandı!',
            '33': 'Burs/öğrenim kredisi kazanan öğrencilere ödeme yapılabilmesi için taahhütnamelerin süresi içerisinde onaylanması gerekiyor. Taahhütname onayı için son gün 20 Aralık.',
            '34': '2 EYLÜL 2022 CUMA',
            '35': 'T.C. GENÇLİK VE SPOR BAKANLIĞI KREDİ VE YURTLAR GENEL MÜDÜRLÜĞÜNDEN DUYURULUR',
            '36': '13 TEMMUZ 2021 SALI',
            '37': 'YABANCI UYRUKLU ÖĞRENCİLERİN DİKKATİNE',
            '38': "BAKAN KASAPOĞLU'NDAN SÜRPRİZ",
            '39': "Bakanımız Dünya Engelliler Günü'nde para masa tenisçilerimize sürpriz yaptı.",
            '40': "DÜNYA GÖNÜLLÜLÜK GÜNÜ'NÜ KUTLADIK",
            '41': 'Gençlik ve Spor Bakanı Dr. Mehmet Muharrem KASAPOĞLU Dünya Gönüllüler Günü Programında Gençlerle Buluştu',
            '42': 'Gençlik ve Spor Bakanlığı ile YÖK Arasında İş Birliği Protokolü',
            '43': 'Gençlik ve Spor Bakanlığı ile YÖK arasında gençlere yönelik faaliyetlere ve genç ofislerine dair iş birliği protokolü imzalandı. Gençlik ve Spor Bakanı Dr. Mehmet Muharrem Kasapoğlu, spor bilimleri fakültelerinde toplamda 8 dönem eğitim gören öğrencilerin 6 dönem üniversitelerde, 2 dönem de bakanlıkta uygulama ve staj eğitimi yapacaklarını açıkladı.',
            '44': 'GÖNÜLLER YAPMAYA GELDİK GALA GECESİ PROGRAMI',
            '45': 'Gönüller Yapmaya Geldik gala gecesi programı Bakanımız sayın Mehmet Muharrem Kasapoğlu’nun teşrifleriyle gerçekleştirildi',
            '46': 'Türkiye-Kazakistan Gençlik Köprüsü Projesi',
            '47': 'Türkiye-Kazakistan Gençlik Köprüsü Projesi kapsamında, 30 Ağustos Zafer Bayramı etkinlikleri için Kazakistan Cumhuriyeti’nden ülkemize gelen gençlere ülkemizin hem tarihi ve kültürel değerleri tanıtıldı, hem de Bakanlık ziyaretleriyle iki ülke arasında işbirliği fırsatları konuşuldu.',
            '48': 'Biz Bir Takımız Projesi Kapanış ve Değerlendirme Çalıştayı Başladı',
            '49': 'Biz Bir Takımız Projesi kapsamında 2022 yılı içerisinde yürütülen iş ve işlemlerin değerlendirilmesi ve bir sonraki dönem için gerekli planlamaların yapılması amacıyla proje paydaşları tarafından düzenlenen Biz Bir Takımız Projesi Kapanış ve Değerlendirme Çalıştayı başladı.',
            '50': 'Adres',
            '51': ': Söğütözü Mah. 2176 Sokak No:25 Çankaya / Ankara',
            '52': 'Telefon',
            '53': 'Belgegeçer',
            '54': 'İletişim Bilgileri',
        },

        'en': {
            '0': 'Login',
            '1': 'Hello!',
            '2': 'Logout',
            '3': 'Home',
            '4': 'Announcements',
            '5': 'Gallery',
            '6': 'Activities',
            '7': 'Contact',
            '8': 'Hello Admin!',
            '9': 'Role Panel',
            '10': 'Person Panel',
            '11': 'Role List',
            '12': 'Role Name',
            '13': 'Delete',
            '14': 'Update',
            '15': 'Add New Role',
            '16': 'Add Role Page',
            '17': 'Role Description',
            '18': 'Save',
            '19': 'People List',
            '20': 'Image',
            '21': 'Person Name',
            '22': 'Person Surname',
            '23': 'Person Phone',
            '24': 'Person Email',
            '25': 'Add New Person',
            '26': 'Update Person Page',
            '27': 'Add Person Page',
            '28': 'Scholarship/Loan News from the Minister of Youth and Sports Kasapoğlu',
            '29': 'The scholarship/loan application deadline has been extended. Young people who did not have the opportunity to apply before, will be able to submit their applications via e-Government until 23:59 on Saturday, 26 November.',
            '30': 'Teens Meet in Konya',
            '31': "During the day trip, historical and cultural places such as Şems-i Tebrizi Tomb/Mosque, Şerafettin Mosque, İplikçi Mosque, Mevlana Tomb and Museum, Butterfly Valley, Martyrs' Cemetery, Alaaddin Hill/ Mosque, Aziziye Mosque will be visited.",
            '32': 'Minister Kasapoğlu Announced: GSB Scholarship/Study Loan Results Announced!',
            '33': 'In order to be able to make payments to students who have won scholarships/study loans, the undertakings must be approved in due time. The last day for the approval of the undertaking is December 20.',
            '34': 'FRIDAY, SEPTEMBER 2, 2022',
            '35': 'T.R. ANNOUNCED FROM THE GENERAL DIRECTORATE OF CREDIT AND DORMITORIES OF THE MINISTRY OF YOUTH AND SPORTS',
            '36': 'TUESDAY, JULY 13, 2021',
            '37': 'TO THE ATTENTION OF FOREIGN STUDENTS',
            '38': 'SURPRISE FROM MINISTER KASAPOĞLU',
            '39': 'Our Minister surprised our table tennis players on the International Day of Persons with Disabilities.',
            '40': 'WE CELEBRATED WORLD VOLUNTEER DAY',
            '41': 'Minister of Youth and Sports Dr. Mehmet Muharrem KASAPOĞLU Met with Youth in the World Volunteers Day Program',
            '42': 'Cooperation Protocol between the Ministry of Youth and Sports and YÖK',
            '43': 'A cooperation protocol on youth activities and youth offices was signed between the Ministry of Youth and Sports and YÖK. Minister of Youth and Sports Dr. Mehmet Muharrem Kasapoğlu announced that students who study at the faculties of sports sciences for a total of 8 terms will do practice and internship training at universities for 6 terms and at the ministry for 2 terms.',
            '44': 'WE CAME TO MAKE HEROES GALA NIGHT PROGRAM',
            '45': 'We Came to Make Hearts gala night program was held with the presence of our Minister Mehmet Muharrem Kasapoğlu.',
            '46': 'Turkey-Kazakhstan Youth Bridge Project',
            '47': 'Within the scope of the Turkey-Kazakhstan Youth Bridge Project, both the historical and cultural values ​​of our country were introduced to the young people who came to our country from the Republic of Kazakhstan for the 30 August Victory Day events, and cooperation opportunities between the two countries were discussed during visits to the Ministry.',
            '48': 'We Are a Team Project Closing and Evaluation Workshop Started',
            '49': 'We are a Team Project Closing and Evaluation Workshop, which was organized by the project stakeholders in order to evaluate the works and transactions carried out in 2022 and to make the necessary plans for the next period, started.',
            '50': 'Adress',
            '51': ': Sogutozu Mah. 2176 Street No:25 Cankaya / Ankara',
            '52': 'Phone',
            '53': 'Documentpass',
            '54': 'Contact information',

        },


    };

    $('.dropdown-item').click(function () {
        localStorage.setItem('dil', JSON.stringify($(this).attr('id')));
        location.reload();
    });

    var lang = JSON.parse(localStorage.getItem('dil'));

    if (lang == "en") {
        $(".drop_yazi").html("English");
    }
    else {
        $(".drop_yazi").html("Türkçe");

    }

    $('a,h5,p,h1,h2,span,li,button,h3,label,tr,td,div,strong').each(function (index, element) {
        $(this).text(arrLang[lang][$(this).attr('key')]);

    });

});

