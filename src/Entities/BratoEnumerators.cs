﻿/*
VERIFICAR SE ESTES TIPOS DEVEM IR NO BANCO DE DADOS
TipoVeiculo [Carro, Motocicleta, Caminhão, Ônibus]
Fabricante [Chevrolet, Fiat, Ford, Honda e etc.]
Modelo [Corsa, Uno, Fiesta, City e etc.]
Cor [Preto, Branco, Cinza, Prata e etc.]

NO MODO RELATÓRIO TODOS OS ENUMS DEVEM CONTER NO ITEM 0 "TODOS" E NÃO "SELECIONE ..."
CRIAR UMA INTELIGENCIA PARA RECONHECER EM QUE MODO O ENUM ESTA SENDO CHAMADO
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace Brato.Entities
{
    public enum BatalhaoEnum
    {
        [Description("Selecione um Item")]
        _SemBatalhao = 0,
        [Description("2º Batalhão")]
        _2BPM = 1,
        [Description("3º Batalhão")]
        _3BPM = 2,
        [Description("4º Batalhão")]
        _4BPM = 3,
        [Description("5º Batalhão")]
        _5BPM = 4,
        [Description("6º Batalhão")]
        _6BPM = 5,
        [Description("7º Batalhão")]
        _7BPM = 6,
        [Description("8º Batalhão")]
        _8BPM = 7,
        [Description("9º Batalhão")]
        _9BPM = 8,
        [Description("10º Batalhão")]
        _10BPM = 9,
        [Description("11º Batalhão")]
        _11BPM = 10,
        [Description("12º Batalhão")]
        _12BPM = 11,
        [Description("14º Batalhão")]
        _14BPM = 12,
        [Description("15º Batalhão")]
        _15BPM = 13,
        [Description("16º Batalhão")]
        _16BPM = 14,
        [Description("17º Batalhão")]
        _17BPM = 15,
        [Description("18º Batalhão")]
        _18BPM = 16,
        [Description("19º Batalhão")]
        _19BPM = 17,
        [Description("20º Batalhão")]
        _20BPM = 18,
        [Description("21º Batalhão")]
        _21BPM = 19,
        [Description("22º Batalhão")]
        _22BPM = 20,
        [Description("23º Batalhão")]
        _23BPM = 21,
        [Description("24º Batalhão")]
        _24BPM = 22,
        [Description("25º Batalhão")]
        _25BPM = 23,
        [Description("26º Batalhão")]
        _26BPM = 24,
        [Description("27º Batalhão")]
        _27BPM = 25,
        [Description("28º Batalhão")]
        _28BPM = 26,
        [Description("29º Batalhão")]
        _29BPM = 27,
        [Description("30º Batalhão")]
        _30BPM = 28,
        [Description("31º Batalhão")]
        _31BPM = 29,
        [Description("32º Batalhão")]
        _32BPM = 30,
        [Description("33º Batalhão")]
        _33BPM = 31,
        [Description("34º Batalhão")]
        _34BPM = 32,
        [Description("35º Batalhão")]
        _35BPM = 33,
        [Description("36º Batalhão")]
        _36BPM = 34,
        [Description("37º Batalhão")]
        _37BPM = 35,
        [Description("38º Batalhão")]
        _38BPM = 36,
        [Description("39º Batalhão")]
        _39BPM = 37,
        [Description("40º Batalhão")]
        _40BPM = 38,
        [Description("41º Batalhão")]
        _41BPM = 39				

    }

    public enum PerfilEnum
    {
        [Description("Selecione um Item")]
        _SemPerfil = 0,
        [Description("Administrador")]
        _Administrador = 1,
        [Description("Policial")]
        _Policial = 2
    }

    public enum CondTempoEnum
    {
        [Description("Selecione um Item")]
        _SemCondTempo = 0,
        [Description("Bom")]
        _Bom = 1,
        [Description("Nublado")]
        _Nublado = 2,
        [Description("Chuvoso")]
        _Chuvoso = 3
    }

    public enum SinalizacaoEnum
    {
        [Description("Selecione um Item")]
        _SemSelecao = 0,
        [Description("Boa")]
        _Boa = 1,
        [Description("Deficiente")]
        _Deficiente = 2,
        [Description("Sem Sinalização")]
        _SemSinalizacao = 3
    }

    public enum TipoAcidenteEnum
    {
        [Description("Selecione um Item")]
        _SemTipoAcidente = 0,
        [Description("Atropelamento")]
        _Atropelamento = 1,
        [Description("Abalroamento")]
        _Abalroamento = 2,
        [Description("Capotamento")]
        _Capotamento = 3,
        [Description("Tombamento")]
        _Tombamento = 4,
        [Description("Choque")]
        _Choque = 5,
        [Description("Colisão")]
        _Colisão = 6
    }

    public enum CircunstanciaEnum
    {
        [Description("Selecione um Item")]
        _SemCircunstacia = 0,
        [Description("Sem Vítima")]
        _SemVitima = 1,
        [Description("Com Vítima(s)")]
        _ComVitima = 2
    }

    public enum SexoEnum
    {
        [Description("Selecione um Item")]
        _SemSexo = 0,
        [Description("Masculino")]
        _Masculino = 1,
        [Description("Feminino")]
        _Feminino = 2
    }

    public enum EstadoCivilEnum
    {
        [Description("Selecione um Item")]
        _SemEstadoCivil = 0,
        [Description("Solteiro(a)")]
        _Solteiro = 1,
        [Description("Casado(a)")]
        _Casado = 2,
        [Description("Separado(a)")]
        _Separado = 3,
        [Description("Divorciado(a)")]
        _Divorciado = 4,
        [Description("Viúvo(a)")]
        _Viuvo = 5
    }

    public enum CategoriaCNH
    {
        [Description("Selecione um Item")]
        _SemCategoriaCNH = 0,
        [Description("A")]
        _A = 1,
        [Description("B")]
        _B = 2,
        [Description("C")]
        _C = 3,
        [Description("D")]
        _D = 4,
        [Description("E")]
        _E = 5,
        [Description("AB")]
        _AB = 6,
        [Description("AC")]
        _AC = 7,
        [Description("AD")]
        _AD = 8,
        [Description("AE")]
        _AE = 9
    }

    public enum FerimentosEnum
    {
        [Description("Selecione um Item")]
        _SemFerimentos = 0,
        [Description("Leve(s)")]
        _Leve = 1,
        [Description("Grave(s)")]
        _Grave = 2,
        [Description("Fatal")]
        _Fatal = 3
    }

    public class EnumeratorHelper
    {
        public EnumeratorHelper()
        {

        }

        //public IList<KeyValuePair<int, string>> GetEnumList(Enum enumerador)
        //{
        //    PropertyInfo[] propriedades = enumerador.GetType().GetProperties();
        //    IList<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();
        //    foreach (var prop in propriedades)
        //    {
        //        int valor = (int)prop.GetValue(prop, null);
        //        DescriptionAttribute[] attributes = (DescriptionAttribute[])prop.GetCustomAttributes(typeof(DescriptionAttribute), false);
        //        string desc = string.Empty;
        //        if (attributes != null && attributes.Length > 0)
        //            desc = attributes[0].Description;
        //        else
        //            desc = prop.ToString();

        //        KeyValuePair<int, string> item = new KeyValuePair<int, string>(valor, desc);
        //        lista.Add(item);
        //    }

        //    return lista;
        //}
    }
}