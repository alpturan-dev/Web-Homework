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

    $('a,h5,p,h1,h2,span,li,button,h3,label,tr,td').each(function (index, element) {
        $(this).text(arrLang[lang][$(this).attr('key')]);

    });

});

