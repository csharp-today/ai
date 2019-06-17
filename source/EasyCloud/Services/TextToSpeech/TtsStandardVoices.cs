using System.Collections.Generic;

namespace EasyCloud.Services.TextToSpeech
{
    // Imported from: https://docs.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support#text-to-speech
    public class TtsStandardVoices
    {
        public readonly IEnumerable<Voice> All;

        internal TtsStandardVoices() => All = new[]
        {
            ar_EG_Hoda, ar_SA_Naayf, bg_BG_Ivan, ca_ES_HerenaRUS, cs_CZ_Jakub, da_DK_HelleRUS, de_AT_Michael, de_CH_Karsten, de_DE_Hedda, de_DE_HeddaRUS, de_DE_Stefan_Apollo, el_GR_Stefanos, en_AU_Catherine, en_AU_HayleyRUS, en_CA_Linda, en_CA_HeatherRUS, en_GB_Susan_Apollo, en_GB_HazelRUS, en_GB_George_Apollo, en_IE_Sean, en_IN_Heera_Apollo, en_IN_PriyaRUS, en_IN_Ravi_Apollo, en_US_ZiraRUS, en_US_JessaRUS, en_US_BenjaminRUS, en_US_Jessa24kRUS, en_US_Guy24kRUS, es_ES_Laura_Apollo, es_ES_HelenaRUS, es_ES_Pablo_Apollo, es_MX_HildaRUS, es_MX_Raul_Apollo, fi_FI_HeidiRUS, fr_CA_Caroline, fr_CA_HarmonieRUS, fr_CH_Guillaume, fr_FR_Julie_Apollo, fr_FR_HortenseRUS, fr_FR_Paul_Apollo, he_IL_Asaf, hi_IN_Kalpana_Apollo, hi_IN_Kalpana, hi_IN_Hemant, hr_HR_Matej, hu_HU_Szabolcs, id_ID_Andika, it_IT_Cosimo_Apollo, it_IT_LuciaRUS, ja_JP_Ayumi_Apollo, ja_JP_Ichiro_Apollo, ja_JP_HarukaRUS, ko_KR_HeamiRUS, ms_MY_Rizwan, nb_NO_HuldaRUS, nl_NL_HannaRUS, pl_PL_PaulinaRUS, pt_BR_HeloisaRUS, pt_BR_Daniel_Apollo, pt_PT_HeliaRUS, ro_RO_Andrei, ru_RU_Irina_Apollo, ru_RU_Pavel_Apollo, ru_RU_EkaterinaRU, sk_SK_Filip, sl_SI_Lado, sv_SE_HedvigRUS, ta_IN_Valluvar, te_IN_Chitra, th_TH_Pattara, tr_TR_SedaRUS, vi_VN_An, zh_CN_HuihuiRUS, zh_CN_Yaoyao_Apollo, zh_CN_Kangkang_Apollo, zh_HK_Tracy_Apollo, zh_HK_TracyRUS, zh_HK_Danny_Apollo, zh_TW_Yating_Apollo, zh_TW_HanHanRUS, zh_TW_Zhiwei_Apollo
        };

        public readonly Voice ar_EG_Hoda = new Voice(Locale.ar_EG, "Arabic (Egypt)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (ar-EG, Hoda)");
        public readonly Voice ar_SA_Naayf = new Voice(Locale.ar_SA, "Arabic (Saudi Arabia)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (ar-SA, Naayf)");
        public readonly Voice bg_BG_Ivan = new Voice(Locale.bg_BG, "Bulgarian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (bg-BG, Ivan)");
        public readonly Voice ca_ES_HerenaRUS = new Voice(Locale.ca_ES, "Catalan (Spain)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (ca-ES, HerenaRUS)");
        public readonly Voice cs_CZ_Jakub = new Voice(Locale.cs_CZ, "Czech", Gender.Male, "Microsoft Server Speech Text to Speech Voice (cs-CZ, Jakub)");
        public readonly Voice da_DK_HelleRUS = new Voice(Locale.da_DK, "Danish", Gender.Female, "Microsoft Server Speech Text to Speech Voice (da-DK, HelleRUS)");
        public readonly Voice de_AT_Michael = new Voice(Locale.de_AT, "German (Austria)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (de-AT, Michael)");
        public readonly Voice de_CH_Karsten = new Voice(Locale.de_CH, "German (Switzerland)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (de-CH, Karsten)");
        public readonly Voice de_DE_Hedda = new Voice(Locale.de_DE, "German (Germany)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (de-DE, Hedda)");
        public readonly Voice de_DE_HeddaRUS = new Voice(Locale.de_DE, "German (Germany)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (de-DE, HeddaRUS)");
        public readonly Voice de_DE_Stefan_Apollo = new Voice(Locale.de_DE, "German (Germany)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (de-DE, Stefan, Apollo)");
        public readonly Voice el_GR_Stefanos = new Voice(Locale.el_GR, "Greek", Gender.Male, "Microsoft Server Speech Text to Speech Voice (el-GR, Stefanos)");
        public readonly Voice en_AU_Catherine = new Voice(Locale.en_AU, "English (Australia)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-AU, Catherine)");
        public readonly Voice en_AU_HayleyRUS = new Voice(Locale.en_AU, "English (Australia)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-AU, HayleyRUS)");
        public readonly Voice en_CA_Linda = new Voice(Locale.en_CA, "English (Canada)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-CA, Linda)");
        public readonly Voice en_CA_HeatherRUS = new Voice(Locale.en_CA, "English (Canada)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-CA, HeatherRUS)");
        public readonly Voice en_GB_Susan_Apollo = new Voice(Locale.en_GB, "English (UK)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-GB, Susan, Apollo)");
        public readonly Voice en_GB_HazelRUS = new Voice(Locale.en_GB, "English (UK)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-GB, HazelRUS)");
        public readonly Voice en_GB_George_Apollo = new Voice(Locale.en_GB, "English (UK)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (en-GB, George, Apollo)");
        public readonly Voice en_IE_Sean = new Voice(Locale.en_IE, "English (Ireland)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (en-IE, Sean)");
        public readonly Voice en_IN_Heera_Apollo = new Voice(Locale.en_IN, "English (India)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-IN, Heera, Apollo)");
        public readonly Voice en_IN_PriyaRUS = new Voice(Locale.en_IN, "English (India)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-IN, PriyaRUS)");
        public readonly Voice en_IN_Ravi_Apollo = new Voice(Locale.en_IN, "English (India)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (en-IN, Ravi, Apollo)");
        public readonly Voice en_US_ZiraRUS = new Voice(Locale.en_US, "English (US)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-US, ZiraRUS)");
        public readonly Voice en_US_JessaRUS = new Voice(Locale.en_US, "English (US)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-US, JessaRUS)");
        public readonly Voice en_US_BenjaminRUS = new Voice(Locale.en_US, "English (US)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (en-US, BenjaminRUS)");
        public readonly Voice en_US_Jessa24kRUS = new Voice(Locale.en_US, "English (US)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (en-US, Jessa24kRUS)");
        public readonly Voice en_US_Guy24kRUS = new Voice(Locale.en_US, "English (US)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (en-US, Guy24kRUS)");
        public readonly Voice es_ES_Laura_Apollo = new Voice(Locale.es_ES, "Spanish (Spain)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (es-ES, Laura, Apollo)");
        public readonly Voice es_ES_HelenaRUS = new Voice(Locale.es_ES, "Spanish (Spain)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (es-ES, HelenaRUS)");
        public readonly Voice es_ES_Pablo_Apollo = new Voice(Locale.es_ES, "Spanish (Spain)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (es-ES, Pablo, Apollo)");
        public readonly Voice es_MX_HildaRUS = new Voice(Locale.es_MX, "Spanish (Mexico)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (es-MX, HildaRUS)");
        public readonly Voice es_MX_Raul_Apollo = new Voice(Locale.es_MX, "Spanish (Mexico)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (es-MX, Raul, Apollo)");
        public readonly Voice fi_FI_HeidiRUS = new Voice(Locale.fi_FI, "Finnish", Gender.Female, "Microsoft Server Speech Text to Speech Voice (fi-FI, HeidiRUS)");
        public readonly Voice fr_CA_Caroline = new Voice(Locale.fr_CA, "French (Canada)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (fr-CA, Caroline)");
        public readonly Voice fr_CA_HarmonieRUS = new Voice(Locale.fr_CA, "French (Canada)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (fr-CA, HarmonieRUS)");
        public readonly Voice fr_CH_Guillaume = new Voice(Locale.fr_CH, "French (Switzerland)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (fr-CH, Guillaume)");
        public readonly Voice fr_FR_Julie_Apollo = new Voice(Locale.fr_FR, "French (France)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (fr-FR, Julie, Apollo)");
        public readonly Voice fr_FR_HortenseRUS = new Voice(Locale.fr_FR, "French (France)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (fr-FR, HortenseRUS)");
        public readonly Voice fr_FR_Paul_Apollo = new Voice(Locale.fr_FR, "French (France)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (fr-FR, Paul, Apollo)");
        public readonly Voice he_IL_Asaf = new Voice(Locale.he_IL, "Hebrew (Israel)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (he-IL, Asaf)");
        public readonly Voice hi_IN_Kalpana_Apollo = new Voice(Locale.hi_IN, "Hindi (India)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (hi-IN, Kalpana, Apollo)");
        public readonly Voice hi_IN_Kalpana = new Voice(Locale.hi_IN, "Hindi (India)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (hi-IN, Kalpana)");
        public readonly Voice hi_IN_Hemant = new Voice(Locale.hi_IN, "Hindi (India)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (hi-IN, Hemant)");
        public readonly Voice hr_HR_Matej = new Voice(Locale.hr_HR, "Croatian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (hr-HR, Matej)");
        public readonly Voice hu_HU_Szabolcs = new Voice(Locale.hu_HU, "Hungarian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (hu-HU, Szabolcs)");
        public readonly Voice id_ID_Andika = new Voice(Locale.id_ID, "Indonesian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (id-ID, Andika)");
        public readonly Voice it_IT_Cosimo_Apollo = new Voice(Locale.it_IT, "Italian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (it-IT, Cosimo, Apollo)");
        public readonly Voice it_IT_LuciaRUS = new Voice(Locale.it_IT, "Italian", Gender.Female, "Microsoft Server Speech Text to Speech Voice (it-IT, LuciaRUS)");
        public readonly Voice ja_JP_Ayumi_Apollo = new Voice(Locale.ja_JP, "Japanese", Gender.Female, "Microsoft Server Speech Text to Speech Voice (ja-JP, Ayumi, Apollo)");
        public readonly Voice ja_JP_Ichiro_Apollo = new Voice(Locale.ja_JP, "Japanese", Gender.Male, "Microsoft Server Speech Text to Speech Voice (ja-JP, Ichiro, Apollo)");
        public readonly Voice ja_JP_HarukaRUS = new Voice(Locale.ja_JP, "Japanese", Gender.Female, "Microsoft Server Speech Text to Speech Voice (ja-JP, HarukaRUS)");
        public readonly Voice ko_KR_HeamiRUS = new Voice(Locale.ko_KR, "Korean", Gender.Female, "Microsoft Server Speech Text to Speech Voice (ko-KR, HeamiRUS)");
        public readonly Voice ms_MY_Rizwan = new Voice(Locale.ms_MY, "Malay", Gender.Male, "Microsoft Server Speech Text to Speech Voice (ms-MY, Rizwan)");
        public readonly Voice nb_NO_HuldaRUS = new Voice(Locale.nb_NO, "Norwegian", Gender.Female, "Microsoft Server Speech Text to Speech Voice (nb-NO, HuldaRUS)");
        public readonly Voice nl_NL_HannaRUS = new Voice(Locale.nl_NL, "Dutch", Gender.Female, "Microsoft Server Speech Text to Speech Voice (nl-NL, HannaRUS)");
        public readonly Voice pl_PL_PaulinaRUS = new Voice(Locale.pl_PL, "Polish", Gender.Female, "Microsoft Server Speech Text to Speech Voice (pl-PL, PaulinaRUS)");
        public readonly Voice pt_BR_HeloisaRUS = new Voice(Locale.pt_BR, "Portuguese (Brazil)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (pt-BR, HeloisaRUS)");
        public readonly Voice pt_BR_Daniel_Apollo = new Voice(Locale.pt_BR, "Portuguese (Brazil)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (pt-BR, Daniel, Apollo)");
        public readonly Voice pt_PT_HeliaRUS = new Voice(Locale.pt_PT, "Portuguese (Portugal)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (pt-PT, HeliaRUS)");
        public readonly Voice ro_RO_Andrei = new Voice(Locale.ro_RO, "Romanian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (ro-RO, Andrei)");
        public readonly Voice ru_RU_Irina_Apollo = new Voice(Locale.ru_RU, "Russian", Gender.Female, "Microsoft Server Speech Text to Speech Voice (ru-RU, Irina, Apollo)");
        public readonly Voice ru_RU_Pavel_Apollo = new Voice(Locale.ru_RU, "Russian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (ru-RU, Pavel, Apollo)");
        public readonly Voice ru_RU_EkaterinaRU = new Voice(Locale.ru_RU, "Russian", Gender.Female, "Microsoft Server Speech Text to Speech Voice (ru-RU, EkaterinaRUS)");
        public readonly Voice sk_SK_Filip = new Voice(Locale.sk_SK, "Slovak", Gender.Male, "Microsoft Server Speech Text to Speech Voice (sk-SK, Filip)");
        public readonly Voice sl_SI_Lado = new Voice(Locale.sl_SI, "Slovenian", Gender.Male, "Microsoft Server Speech Text to Speech Voice (sl-SI, Lado)");
        public readonly Voice sv_SE_HedvigRUS = new Voice(Locale.sv_SE, "Swedish", Gender.Female, "Microsoft Server Speech Text to Speech Voice (sv-SE, HedvigRUS)");
        public readonly Voice ta_IN_Valluvar = new Voice(Locale.ta_IN, "Tamil (India)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (ta-IN, Valluvar)");
        public readonly Voice te_IN_Chitra = new Voice(Locale.te_IN, "Telugu (India)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (te-IN, Chitra)");
        public readonly Voice th_TH_Pattara = new Voice(Locale.th_TH, "Thai", Gender.Male, "Microsoft Server Speech Text to Speech Voice (th-TH, Pattara)");
        public readonly Voice tr_TR_SedaRUS = new Voice(Locale.tr_TR, "Turkish", Gender.Female, "Microsoft Server Speech Text to Speech Voice (tr-TR, SedaRUS)");
        public readonly Voice vi_VN_An = new Voice(Locale.vi_VN, "Vietnamese", Gender.Male, "Microsoft Server Speech Text to Speech Voice (vi-VN, An)");
        public readonly Voice zh_CN_HuihuiRUS = new Voice(Locale.zh_CN, "Chinese (Mainland)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (zh-CN, HuihuiRUS)");
        public readonly Voice zh_CN_Yaoyao_Apollo = new Voice(Locale.zh_CN, "Chinese (Mainland)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (zh-CN, Yaoyao, Apollo)");
        public readonly Voice zh_CN_Kangkang_Apollo = new Voice(Locale.zh_CN, "Chinese (Mainland)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (zh-CN, Kangkang, Apollo)");
        public readonly Voice zh_HK_Tracy_Apollo = new Voice(Locale.zh_HK, "Chinese (Hong Kong)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (zh-HK, Tracy, Apollo)");
        public readonly Voice zh_HK_TracyRUS = new Voice(Locale.zh_HK, "Chinese (Hong Kong)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (zh-HK, TracyRUS)");
        public readonly Voice zh_HK_Danny_Apollo = new Voice(Locale.zh_HK, "Chinese (Hong Kong)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (zh-HK, Danny, Apollo)");
        public readonly Voice zh_TW_Yating_Apollo = new Voice(Locale.zh_TW, "Chinese (Taiwan)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (zh-TW, Yating, Apollo)");
        public readonly Voice zh_TW_HanHanRUS = new Voice(Locale.zh_TW, "Chinese (Taiwan)", Gender.Female, "Microsoft Server Speech Text to Speech Voice (zh-TW, HanHanRUS)");
        public readonly Voice zh_TW_Zhiwei_Apollo = new Voice(Locale.zh_TW, "Chinese (Taiwan)", Gender.Male, "Microsoft Server Speech Text to Speech Voice (zh-TW, Zhiwei, Apollo)");
    }
}
