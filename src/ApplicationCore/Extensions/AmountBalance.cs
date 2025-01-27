﻿using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel;
using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel;
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metcom.XMLSummator.ApplicationCore.Extensions
{
    public class AmountBalance : IAmountBalances
    {
        private ReportForm[] _reportForms;
        

        //TODO: Реализовать нормально сложение двух файлов в один
        /// <summary>
        /// Формирование итоговой формы
        /// </summary>
        /// <param name="reportForms"></param>
        /// <returns>Колекция форм</returns>
        public ReportForm AmountBalances(ICollection<ReportForm> reportForms)
        {
            _reportForms = reportForms.ToArray();

            var firstFileData = _reportForms[0];
            var secondFileData = _reportForms[1];

            ReportForm res = new ReportForm()
            {
                MainFormAttrebute = firstFileData.MainFormAttrebute,
                PersonData = firstFileData.PersonData,
                FooterData = firstFileData.FooterData,
            };

            var firstBalanceCollection = firstFileData.BalanceCollection;
            var secondBalanceCollection = secondFileData.BalanceCollection;


            var resultBalanceCollection = SumBalance(firstBalanceCollection, secondBalanceCollection);

            res.BalanceCollection = resultBalanceCollection;

            return res;
        }

        #region ShitCode

        private BalanceCollection SumBalance(BalanceCollection firstBalance, BalanceCollection secondBalance)
        {

            var resultBalances = firstBalance.Balances.Concat(secondBalance.Balances)
                .GroupBy(x => new { x.BalanceType, x.Currency, x.SecondOrderAccount, x.Feature })
                .Select(x => new Balance()
                {
                    BalanceType = x.Key.BalanceType,
                    SecondOrderAccount = x.Key.SecondOrderAccount,
                    Currency = x.Key.Currency,
                    Feature = x.Key.Feature,
                    DebitTurnover = x.Sum(z => z.DebitTurnover),
                    IncomingBalance = x.Sum(z => z.IncomingBalance),
                    LoanTurnover = x.Sum(z => z.LoanTurnover),
                    OutgoingBalance = x.Sum(z => z.OutgoingBalance)
                })
                .ToArray();

            var resultBalancesOut = firstBalance.BalancesOut.Concat(secondBalance.BalancesOut)
                .GroupBy(x => new { x.BalanceType, x.Currency, x.SecondOrderAccount, x.Feature })
                .Select(x => new BalanceOut()
                {
                    BalanceType = x.Key.BalanceType,
                    SecondOrderAccount = x.Key.SecondOrderAccount,
                    Currency = x.Key.Currency,
                    Feature = x.Key.Feature,
                    DebitTurnover = x.Sum(z => z.DebitTurnover),
                    IncomingBalance = x.Sum(z => z.IncomingBalance),
                    LoanTurnover = x.Sum(z => z.LoanTurnover),
                    OutgoingBalance = x.Sum(z => z.OutgoingBalance)
                })
                .ToArray();

            var resultBalancesFaster = firstBalance.BalancesFaster.Concat(secondBalance.BalancesFaster)
                .GroupBy(x => new { x.BalanceType, x.Currency, x.SecondOrderAccount, x.Feature })
                .Select(x => new BalanceFaster()
                {
                    BalanceType = x.Key.BalanceType,
                    SecondOrderAccount = x.Key.SecondOrderAccount,
                    Currency = x.Key.Currency,
                    Feature = x.Key.Feature,
                    DebitTurnover = x.Sum(z => z.DebitTurnover),
                    IncomingBalance = x.Sum(z => z.IncomingBalance),
                    LoanTurnover = x.Sum(z => z.LoanTurnover),
                    OutgoingBalance = x.Sum(z => z.OutgoingBalance)
                })
                .ToArray();

            var resultTotalBalances = firstBalance.TotalBalances.Concat(secondBalance.TotalBalances)
                .GroupBy(x => new { x.BalanceType, x.Currency, x.Feature })
                .Select(x => new TotalBalance()
                {
                    BalanceType = x.Key.BalanceType,
                    Currency = x.Key.Currency,
                    Feature = x.Key.Feature,
                    DebitTurnover = x.Sum(z => z.DebitTurnover),
                    IncomingBalance = x.Sum(z => z.IncomingBalance),
                    LoanTurnover = x.Sum(z => z.LoanTurnover),
                    OutgoingBalance = x.Sum(z => z.OutgoingBalance)
                })
                .ToArray();

            var resultTotalTrusts = firstBalance.TotalTrusts.Concat(secondBalance.TotalTrusts)
                .GroupBy(x => new { x.BalanceType, x.Currency, x.Feature })
                .Select(x => new TotalTrust()
                {
                    BalanceType = x.Key.BalanceType,
                    Currency = x.Key.Currency,
                    Feature = x.Key.Feature,
                    DebitTurnover = x.Sum(z => z.DebitTurnover),
                    IncomingBalance = x.Sum(z => z.IncomingBalance),
                    LoanTurnover = x.Sum(z => z.LoanTurnover),
                    OutgoingBalance = x.Sum(z => z.OutgoingBalance)
                })
                .ToArray();

            var resultTotalOutBalances = firstBalance.TotalOutBalances.Concat(secondBalance.TotalOutBalances)
                .GroupBy(x => new { x.BalanceType, x.Currency, x.Feature })
                .Select(x => new TotalOutBalance()
                {
                    BalanceType = x.Key.BalanceType,
                    Currency = x.Key.Currency,
                    Feature = x.Key.Feature,
                    DebitTurnover = x.Sum(z => z.DebitTurnover),
                    IncomingBalance = x.Sum(z => z.IncomingBalance),
                    LoanTurnover = x.Sum(z => z.LoanTurnover),
                    OutgoingBalance = x.Sum(z => z.OutgoingBalance)
                })
                .ToArray();

            var resultTotalFastBalances = firstBalance.TotalFastBalances.Concat(secondBalance.TotalFastBalances)
                .GroupBy(x => new { x.BalanceType, x.Currency, x.Feature })
                .Select(x => new TotalFastBalance()
                {
                    BalanceType = x.Key.BalanceType,
                    Currency = x.Key.Currency,
                    Feature = x.Key.Feature,
                    DebitTurnover = x.Sum(z => z.DebitTurnover),
                    IncomingBalance = x.Sum(z => z.IncomingBalance),
                    LoanTurnover = x.Sum(z => z.LoanTurnover),
                    OutgoingBalance = x.Sum(z => z.OutgoingBalance)
                }).ToArray();

            var result = new BalanceCollection()
            {
                Id = firstBalance.Id,
                Balances = resultBalances,
                BalancesFaster = resultBalancesFaster,
                BalancesOut = resultBalancesOut,
                TotalBalances = resultTotalBalances,
                TotalFastBalances = resultTotalFastBalances,
                TotalOutBalances = resultTotalOutBalances,
                TotalTrusts = resultTotalTrusts
            };

            return result;
        }

        #endregion

    }
}
