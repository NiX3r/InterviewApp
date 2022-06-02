using InterviewApp.utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewApp
{
    internal static class Program
    {

        private static Dictionary<string, Dictionary<string, object>> languageSet;

        [STAThread]
        static void Main()
        {
            if (DatabaseUtils.setupDatabase())
            {
                languageSet = new Dictionary<string, Dictionary<string, object>>();
                setupLanguageSet();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

        private static void setupLanguageSet()
        {
            // CZECH
            Dictionary<string, object> language = new Dictionary<string, object>();
            language.Add("label_fullname", "Jméno a příjmení");
            language.Add("label_identify_number", "Rodné číslo");
            language.Add("checkbox_have_id_number", "nemám RČ");
            language.Add("label_birth", "Datum narození");
            language.Add("label_sex", "Pohlaví");
            language.Add("label_nationality", "Státní příslušenství");
            language.Add("checkbox_agree_with_GDPR", "Souhlas s");
            language.Add("button_send", "Odeslat");
            language.Add("combobox_sex_list", new string[] { "Muž", "Žena", "Jiné"});
            language.Add("combobox_nationality_list", new string[] { "Afghánistán", "Albánie", "Alžírsko", "Andorra", "Angola", "Antigua a Barbuda", "Argentina", "Arménie", "Austrálie", "Rakousko", "Ázerbájdžán", "Bahamy", "Bahrajn", "Bangladéš", "Barbados", "Bělorusko", "Belgie", "Belize", "Benin", "Bhútán", "Bolívie", "Bosna a Hercegovina", "Botswana", "Brazílie", "Brunej", "Bulharsko", "Burkina Faso", "Burundi", "Kambodža", "Kamerun", "Kanada", "Kapverdy", "Středoafrická republika", "Čad", "Chile", "Čína", "Colombi", "Komory", "Kongo (Brazzaville)", " Kongo", "Kostarika", "Pobřeží slonoviny", "Chorvatsko", "Kuba", "Kypr", "Česká republika", "Dánsko", "Džibutsko", "Dominika", "Dominikánská republika", "Východní Timor (Timor Timur)", "Ekvádor", "Egypt", "Salvador", "Rovníková Guinea", "Eritrea", "Estonsko", "Etiopie", "Fidži", "Finsko", "Francie", "Gabon", "Gambie, The", "Gruzie", "Německo", "Ghana", "Řecko", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Maďarsko", "Island", "Indie", "Indonésie", "Írán", "Irák", "Irsko", "Izrael", "Itálie", "Jamajka", "Japonsko", "Jordánsko", "Kazachstán", "Keňa", "Kiribati", "Korea, sever", "Korea, jih", "Kuvajt", "Kyrgyzstán", "Laos", "Lotyšsko", "Libanon", "Lesotho", "Libérie", "Libye", "Lichtenštejnsko", "Litva", "Lucembursko", "Makedonie", "Madagaskar", "Malawi", "Malajsie", "Maledivy", "Mali", "Malta", "Marshallovy ostrovy", "Mauritánie", "Mauricius", "Mexiko", "Mikronésie", "Moldavsko", "Monako", "Mongolsko", "Maroko", "Mosambik", "Myanmar", "Namibie", "Nauru", "Nepál", "Nizozemsko", "Nový Zéland", "Nikaragua", "Niger", "Nigérie", "Norsko", "Omán", "Pákistán", "Palau", "Panama", "Papua-Nová Guinea", "Paraguay", "Peru", "Filipíny", "Polsko", "Portugalsko", "Katar", "Rumunsko", "Rusko", "Rwanda", "Svatý Kryštof a Nevis", "Svatá Lucie", "Svatý Vincenc", "Samoa", "San Marino", "Svatý Tomáš a Princův ostrov", "Saúdská Arábie", "Senegal", "Srbsko a Černá Hora", "Seychely", "Sierra Leone", "Singapur", "Slovensko", "Slovinsko", "Šalamounovy ostrovy", "Somálsko", "Jižní Afrika", "Španělsko", "Srí Lanka", "Súdán", "Surinam", "Svazijsko", "Švédsko", "Švýcarsko", "Sýrie", "Tchaj-wan", "Tádžikistán", "Tanzanie", "Thajsko", "Togo", "Tonga", "Trinidad a Tobago", "Tunisko", "Turecko", "Turkmenistán", "Tuvalu", "Uganda", "Ukrajina", "Spojené arabské emiráty", "Spojené království", "Spojené státy", "Uruguay", "Uzbekistán", "Vanuatu", "Vatikán", "Venezuela", "Vietnam", "Jemen", "Zambie", "Zimbabwe" });
            language.Add("message_email_bad_format", "Špatný formát emailu. Prosím napište Váš email ještě jednou.");
            language.Add("message_all_parameters", "Nevyplnil jste všechny potřebné údaje. Prosím zkontrolujte si vyplněné údaje.");
            languageSet.Add("cs", language);
            // ENGLISH
            language = new Dictionary<string, object>();
            language.Add("label_fullname", "Fullname");
            language.Add("label_identify_number", "Personal identify number");
            language.Add("checkbox_have_id_number", "haven't PIN");
            language.Add("label_birth", "Birth date");
            language.Add("label_sex", "Sex");
            language.Add("label_nationality", "Nationality");
            language.Add("checkbox_agree_with_GDPR", "Agree with");
            language.Add("button_send", "Send");
            language.Add("combobox_sex_list", new string[] { "Man", "Woman", "Other" });
            language.Add("combobox_nationality_list", new string[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Republic", "Chad", "Chile", "China", "Colombi", "Comoros", "Congo (Brazzaville)", "Congo", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor Timur)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia and Montenegro", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            language.Add("message_email_bad_format", "Uncorrect email format. Please type your email again.");
            language.Add("message_all_parameters", "You have not filled in all the necessary data. Please double check your filled data.");
            languageSet.Add("en", language);

        }

        public static Dictionary<string, Dictionary<string, object>> getLanguageSet()
        {
            return languageSet;
        }
    }
}
