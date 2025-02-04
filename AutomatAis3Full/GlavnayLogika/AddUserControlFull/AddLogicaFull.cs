﻿using System.Collections.ObjectModel;
using AutomatAis3Full.Form.Automat.Analitic.Zadanie.ZacetVozvrat.Signature;
using AutomatAis3Full.Form.Automat.It.Rule.UserControl;
using AutomatAis3Full.Form.Automat.It.RuleInfoFull.UserControl;
using AutomatAis3Full.Form.Automat.It.UserTemplateAndRule.UserControl;
using AutomatAis3Full.Form.Automat.Kao.InterrogationOfWitnesses.InterrogationOfWitnessesView;
using AutomatAis3Full.Form.Automat.Okp2.RegisterDeclarations.RegisterDeclarations;
using AutomatAis3Full.Form.Automat.Okp3.UsnSend.UsnSend;
using AutomatAis3Full.Form.Automat.Okp4.FormSnuAuto.SnuFormAuto;
using AutomatAis3Full.Form.Automat.Okp4.MassSnuForm.MassSnuForm;
using AutomatAis3Full.Form.Automat.Okp4.PravoEdit.PravoEdit;
using AutomatAis3Full.Form.Automat.Okp4.PrintSnu.Print;
using AutomatAis3Full.Form.Automat.Okp5.ActIzvesheniaReshenia121.ActIzvesheniaReshenia;
using AutomatAis3Full.Form.Automat.Okp5.Identification.FaceIdentification;
using AutomatAis3Full.Form.Automat.Orn.ConfirmationNbo.ConfirmationNbo;
using AutomatAis3Full.Form.Automat.PreCheck.Journal129.Journal129;
using AutomatAis3Full.Form.Automat.PreCheck.ReportingMemo.ReportingMemo;
using AutomatAis3Full.Form.Automat.RaschetBudg.Migration.Migration;
using AutomatAis3Full.Form.Automat.RaschetBudg.VedRazd1.VedRaz1;
using AutomatAis3Full.Form.Automat.Registration.ActualStatus.UserControlStatus;
using AutomatAis3Full.Form.Automat.Registration.Journal.ReceivedDocument.ReceivedDocuments;
using AutomatAis3Full.Form.Automat.Registration.Rosreestr.UserControl;
using AutomatAis3Full.Form.Automat.Registration.TehnicalUpdate.UserControlTechnical;
using AutomatAis3Full.Form.Automat.Registration.TreatmentFPD.Zemly.UserControl;
using AutomatAis3Full.Form.Automat.Registration.VisualBank.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.FormTrebUplNaloga.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Uvedomlenie0509.MessageLk.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Uvedomlenie0509.RenouncementLk.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Ticket05080902.Ticket0508090203.Ticket050809020306.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.RequirementsLog.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.SenderReshenia.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.SenderSpravk.UserControl;
using AutomatAis3Full.Form.FormirovanieSpiskov.Spiski.FormFormirovanie;
using AutomatAis3Full.Form.Report.ReportXml.ReportForm;
using LibraryCommandPublic.TestAutoit.Reg.YtochnenieSved.AutoCommand;
using ViewModelLib.ModelTestAutoit.FullWindowAutoIt;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Ticket05080902.Ticket0508090202.Ticket050809020204.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Ticket05080902.Ticket0508090202.Ticket050809020206.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Uvedomlenie0509.SigningDecisionApplication.UserControl;
using AutomatAis3Full.Form.Automat.Okp1.Declaration121.Declaration121;
using AutomatAis3Full.Form.Automat.Okp1.Declaration121ActIsh.Declaration121ActIsh;
using AutomatAis3Full.Form.Automat.Okp2.UserTask.TaxApprove.TaxApprove;
using AutomatAis3Full.Form.Automat.Okp3.JournalPatent.Patent;
using AutomatAis3Full.Form.Automat.Okp6.JournalDoc.ViewJournalDoc;
using AutomatAis3Full.Form.Automat.Okp6.RegistryDeclaration.ViewRegistryDeclaration;
using AutomatAis3Full.Form.Automat.Uregulirovanie.StartProcessFace.StartCash.ViewStartCash;
using AutomatAis3Full.Form.FormirovanieSpiskov.AutoGenerateListAutomation.ViewGenerator;
using AutomatAis3Full.Form.Automat.Okp1.Declaration121Error.Declaration121Error;
using AutomatAis3Full.Form.Automat.RaschetBudg.Krsb.Krsb;
using AutomatAis3Full.Form.Automat.Registration.AcceptanceDocuments.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.StatementNp.ViewStatementNp;
using AutomatAis3Full.Form.Automat.Okp1.EasJournal.EasJournal;
using AutomatAis3Full.Form.Automat.Okp4.RealEstateInquiries.ViewRealEstateInquiries;
using AutomatAis3Full.Form.Automat.Okp6.AddRequirements.ViewAddRequirements;
using AutomatAis3Full.Form.Automat.Okp6.CheckDeclaration.ViewCheckDeclaration;
using AutomatAis3Full.Form.Automat.Uregulirovanie.ClearStatusStatementNp.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Uvedomlenie0509.ApplicationManualProcessing.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Uvedomlenie0509.DecisionsApproval.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Uvedomlenie0509.MessageApproval.UserControl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.Uvedomlenie0509.StatementDecisionApplication.UserControl;
using AutomatAis3Full.Form.Automat.Okp6.AddTerm.ViewAddTerm;
using AutomatAis3Full.Form.Automat.Okp6.DeclarationComplex.ViewDeclarationComplex;
using AutomatAis3Full.Form.Automat.Uregulirovanie.StartProcessFace.JudicialAct.ViewJudicialAct;
using AutomatAis3Full.Form.Automat.Okp6.DeclarationCalculation.ViewDeclarationCalculation;
using AutomatAis3Full.Form.Automat.Okp6.DocumentOwnerFact.OwnerFactIm.ViewOwnerFactIm;
using AutomatAis3Full.Form.Automat.Okp6.DocumentOwnerFact.OwnerFactZm.ViewOwnerFactZm;
using AutomatAis3Full.Form.Automat.Orn.Ion.FaceRegistryReference.ViewFaceRegistryReference;
using AutomatAis3Full.Form.Automat.Orn.IonSend.FaceRegistryReferenceSend.ViewFaceRegistryReferenceSend;
using AutomatAis3Full.Form.Automat.PublicFunctionLogics.PublicTaxJournal.FormTaxJournal;
using AutomatAis3Full.Form.Automat.RaschetBudg.IncomeJournal.FormIncomeJournal;
using AutomatAis3Full.Form.Automat.Registration.DocumentScan.UserControlScan;
using AutomatAis3Full.Form.Automat.Registration.DocumentScanAddContainer.UserControlScanAddContainer;
using AutomatAis3Full.Form.Automat.Uregulirovanie.TechKorrect.ViewTechAdjustmentStatement;
using AutomatAis3Full.Form.Automat.Uregulirovanie.TechKorrectAgreement.ViewTechKorrectAgreement;
using AutomatAis3Full.Form.Automat.Registration.IdentificationFace.IdentificationFl.ViewIdentificationFl;
using AutomatAis3Full.Form.Automat.Uregulirovanie.PrintDocument.UserControlPrintDocument;
using AutomatAis3Full.Form.Automat.Uregulirovanie.StartProcess.Collection.ViewCollection;
using AutomatAis3Full.Form.Automat.Uregulirovanie.StartProcess.Requirement.ViewRequirement;

namespace AutomatAis3Full.GlavnayLogika.AddUserControlFull
{

    public class AddLogicaFull
      {
          /// <summary>
          /// Рефлизация древовидной структуры
          /// </summary>
          /// <returns></returns>
          public FullWindowAutoItMethod FullWindowAdd()
          {
              FullWindowAutoItMethod autoit = new FullWindowAutoItMethod();
              var ytochnenieSved = new YtochnenieSved();
            ObservableCollection<FullWindowAutoIt> window = new ObservableCollection<FullWindowAutoIt>
              {
                  new FullWindowAutoIt()
                  {
                      NameControl = "Отдел информатизации",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "ЦСУД",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Управление ролевой принадлежностью",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Журнал заявок",
                                              UserControl = new RuleParse()
                                          },
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Мои роли (Сбор всех веток!)",
                                              UserControl = new FormRuleInfoFull()
                                          },
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Просмотр ролей (Сбор пользователей, ролей, шаблонов)",
                                              UserControl = new FormUserTemplateAndRule()
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Отдел перепроверенного анализа",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Докладная записка",
                              UserControl = new ReportingMemo()
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "129. Налоговые правонарушения",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "2. Журнал налоговых правонарушений",
                                      UserControl = new Journal129()
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Урегулирование задолженности",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Урегулирование задолженности (ЕНС)",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Взыскание задолженности за счет ДС и ЭДС",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Запуск БП",
                                              UserControl = new ViewCollection()
                                          }
                                      }
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Требования об уплате",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Запуск БП",
                                              UserControl = new ViewRequirement()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Проведение зачетов/возвратов",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Заявления НП о зачете/возврате (реестр)",
                                      UserControl = new ViewStatementNp()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Заявления НП о зачете/возврате (реестр) Очистить состояние обработки",
                                      UserControl = new FormClearStatusStatementNp()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Техническая корректировка. Ввод заявок",
                                      UserControl = new ViewTechAdjustmentStatement()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Техническая корректировка. Согласование заявок",
                                      UserControl = new ViewTechKorrectAgreement()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Взыскание задолженности за счет ден. средств",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Запуск БП",
                                      UserControl = new ViewStartCash()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Ввод данных судебного акта",
                                      UserControl = new ViewJudicialAct()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Требования об уплате",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Журнал требований об уплате",
                                      UserControl = new RequirementsLog()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Общие задания",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.08.10.01 Списание задолженности",
                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                   {
                                     new FullWindowAutoIt()
                                     {
                                         NameControl  = "05.08.10.01.0X.01.02. Подписание Справки о суммах недоимки и задолженности",
                                         UserControl = new SenderSpravk()
                                     },
                                     new FullWindowAutoIt()
                                     {
                                         NameControl = "05.08.10.01.0X.02. Подписание решения. Создание операций в КРСБ",
                                         UserControl = new SenderReshenia()
                                     }
                                   }
                               },
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.08.09.02. Взыскание задолженности за счет имущества",
                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                   {
                                      new FullWindowAutoIt()
                                      {
                                          NameControl = "05.08.09.02.02. Утверждение и подписание Служебных записок",
                                          CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                          {
                                              new FullWindowAutoIt()
                                              {
                                                  NameControl = "05.08.09.02.02.04. Утверждение Служебной записки",
                                                  UserControl = new StatementOfficeNote()
                                              },
                                              new FullWindowAutoIt()
                                              {
                                                  NameControl = "05.08.09.02.02.06. Подписание Служебной записки",
                                                  UserControl = new SignatureOfficeNote()
                                              },
                                          }
                                      },
                                      new FullWindowAutoIt()
                                      {
                                          NameControl = "Утверждение и подписание Заявлений о взыскании за счет имущества ФЛ",
                                          CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                          {
                                              new FullWindowAutoIt()
                                              {
                                                  NameControl = "05.08.09.02.03.06. Подпись руководителем взысканий за счет имущества",
                                                  UserControl = new SignatureHeadProperty()
                                              }
                                          }
                                      }
                                   }
                               },
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.08.03.0X.03. Утверждение требований об уплате",
                                   UserControl = new FormTrebUplNaloga()
                               },
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.09 Уведомление о необходимости выгрузки документов в ЛК",
                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                   {
                                       new FullWindowAutoIt()
                                       {
                                           NameControl = "05.09 Сообщения о принятом решении о зачете (возврате) подлежащие выгрузке в ЛК",
                                           UserControl = new MessageLk()
                                       },
                                       new FullWindowAutoIt()
                                       {
                                           NameControl = "05.09 Сообщения о принятом решении об отказе  подлежащие выгрузке в ЛК",
                                           UserControl = new RecouncementLk()
                                       }
                                   }
                               },
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.09 Ручное формирование решений на зачет/возврат/возврат процентов",
                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                   {
                                       new FullWindowAutoIt()
                                       {
                                           NameControl = "05.09 Заявления НП для ручной обработки",
                                           UserControl = new ApplicationManualProcessing()
                                       }
                                   }
                               },
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.09.01(06.01) Формирование сообщения о факте излишней уплаты (излишнего взыскания)",
                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                   {
                                       new FullWindowAutoIt()
                                       {
                                           NameControl = "05.09.01(06.01) Формирование сообщения об излишней уплате (взыскании)",
                                           CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                           {
                                               new FullWindowAutoIt()
                                               {
                                                   NameControl = "05.09.01(06.01) Формирование решений о зачете по инициативе НО",
                                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                                   {
                                                       new FullWindowAutoIt()
                                                       {
                                                           NameControl = "Утверждение решений о зачете",
                                                           UserControl = new DecisionsApproval()
                                                       }
                                                   }
                                               },
                                               new FullWindowAutoIt()
                                               {
                                                   NameControl = "Утверждение сообщений",
                                                   UserControl = new MessageApproval()
                                               }
                                           }
                                       }
                                   }
                               },
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.09 Формирование решения об отказе по заявлению (Подписание руководителем НО)",
                                   UserControl = new SigningDecisionApplication()
                               },
                               new FullWindowAutoIt()
                               {
                                   NameControl = "05.09 Формирование решения об отказе по заявлению (Утверждение)",
                                   UserControl = new StatementDecisionApplication()
                               }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Направление документов налогоплательщику",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "2. Единичная печать и отправка в ОПС",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Печать и отправка",
                                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                              {
                                                  new FullWindowAutoIt()
                                                  {
                                                      NameControl = "2 - Документы к отправке",
                                                      UserControl = new UserControlPrintDocument()
                                                  }
                                              }
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "ОКП1",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "121. Камеральная налоговая проверка",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все)",
                                      UserControl = new  FormDeclaration121()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все) (Нарушения)",
                                      UserControl = new FormDeclaration121Error()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все) (Акты Извещения Решения)",
                                      UserControl = new FormDeclaration121ActIsh()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "114. ЕАЭС-обмен",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                       NameControl = "03. Реестр исходящих документов для обработки и отправки",
                                       UserControl = new FormEasJournal()
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "ОКП2",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "121. Камеральная налоговая проверка",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все)",
                                      UserControl = new FormRegisterDeclarations()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "129. Налоговые правонарушения",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "2. Журнал налоговых правонарушений",
                                      UserControl = new FormTaxJournal()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Контрольная работа (налоговые проверки)",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "111. Формирование налоговых обязанностей",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Утверждение налоговых обязанностей",
                                              UserControl = new ViewTaxApprove()
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "ОКП3",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Общие задания",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {

                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Контрольная работа налоговые проверки",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Применение упрощенной системы налогообложения",
                                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                              {
                                                  new FullWindowAutoIt()
                                                  {
                                                      NameControl = "Применение УСН",
                                                      UserControl = new FormUsnSend()
                                                  }
                                              }
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Контрольная работа (налоговые проверки)",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все) (Акты Извещения Решения)",
                                      UserControl = new FormDeclaration121ActIsh()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "203. Применение патентной системы налогообложения",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "03. Журнал учета и формирования документов, связанных с применением ПСН",
                                              UserControl = new FormPatent()
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  },
                      new FullWindowAutoIt()
                  {
                      NameControl = "ОКП4",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Собственность",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "08. Взаимодействие с органами Росреестра – Объекты недвижимости",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "09. Уточняющие запросы - Витрина запросов для уточнения сведений",
                                              UserControl = new ViewRealEstateInquiries()
                                          }
                                      }
                                  }
                               
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "1.06 Формирование и печать СНУ",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "1 Создание заявки на формирование СНУ",
                                      UserControl = new FormSnuAuto()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "1 Создание заявки на формирование СНУ массово!!!",
                                      UserControl = new MassSnuForm()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "2. Просмотр СНУ",
                                      UserControl = new UserPrintSnu()
                                  },
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "02. Доопределение данных об объектах собственности",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "14.КС–Корректировка сведений о правах не зарегистрированных  в органах Росреестра и правах наследования на ОН и ЗУ",
                                      UserControl = new PravoEditForm()
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "ОКП5",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "106. Реестр расчетов по страховым взносам и персонифицированным сведениям",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Реестр расчетов по страховым взносам, сведения о КНП (все) (Акты, Извещение, Решения)",
                                      UserControl = new ActIzvesheniaResheniaView()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "121. Камеральная налоговая проверка",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {

                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все) (Нарушения)",
                                      UserControl = new FormDeclaration121Error()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "129. Налоговые правонарушения",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "2. Журнал налоговых правонарушений",
                                      UserControl = new FormTaxJournal()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Физические лица",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "2.01. Сведения о доходах ФЛ",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "5.01. Неидентифицированные получатели дохода",
                                              UserControl = new FaceIdentificationView(),
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "ОКП6",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Собственность",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "01. Картотека собственности ФБД",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "07. КС – ЗУ – Факты владения на земельные участки – ФЛ",
                                              UserControl = new ViewOwnerFactZm()
                                          },
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "23. КС – ОН – Факты владения на объекты недвижимости – ФЛ",
                                              UserControl = new ViewOwnerFactIm()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "121. Камеральная налоговая проверка",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "04. Журнал документов, выписанных в ходе налоговой проверки",
                                      UserControl = new JourrnalDocView()
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "122. Камеральная налоговая проверка НДФЛ",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все)  (Акты, Извещения, Решения)",
                                      UserControl = new RegistryDeclarationView()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все)  (Проверка деклараций->Закрытие)",
                                      UserControl = new CheckDeclarationView()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все)  (Проставление срока!)",
                                      UserControl = new AddTermView()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "03. Реестр налоговых деклараций (расчетов), сведения о КНП (все)  (Закрытие комплекса мероприятий!)",
                                      UserControl = new DeclarationComplexView()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "04. Реестр расчетов по продаже и(или) дарению объектов недвижимости в подлежащих КНП в соответствии с п.1.2 ст. 88НК (Решения)",
                                      UserControl = new ViewDeclarationCalculation()
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "04. Реестр расчетов по продаже и(или) дарению объектов недвижимости в подлежащих КНП в соответствии с п.1.2 ст. 88НК (Требования)",
                                      UserControl = new AddRequirementsView()
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "ОКП7",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "129. Налоговые правонарушения",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "2. Журнал налоговых правонарушений",
                                      UserControl = new FormTaxJournal()
                                  }
                              }
                          },
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Контрольно-аналитический отдел",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Контрольная работа",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Допрос свидетелей",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Инициализация процедуры допроса свидетеля",
                                              UserControl = new InterrogationOfWitnessesView()
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Расчеты с бюджетом",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Расчеты с бюджетом",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Ведение КРСБ",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Просмотр списка КРСБ налогоплательщика",
                                              UserControl = new Krsb()
                                          }
                                      }
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Ведомость невыясненных поступлений",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Ведомость невыясненных поступлений. Раздел 1",
                                              UserControl = new VedRaz1()
                                          }
                                      }
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Журнал неналоговых доходов",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Раздел II. Доходы, начисления по которым отсутствуют в базе данных налоговых органов",
                                              UserControl = new ViewIncomeJournal()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "ПОН Координация",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Миграция НП",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Журнал миграции НП",
                                              UserControl = new Migration()
                                          }
                                      }
                                      
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Аналитический",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Урегулирование задолженности",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "05.09 Подпись проектов решений на зачет/возврат",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Подпись начальником аналитического отдела",
                                              UserControl = new SigZacetVozvrat()
                                          }
                                      }
                                  }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "ОРН",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Контрольная работа (налоговые проверки)",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                               new FullWindowAutoIt()
                               {
                                   NameControl = "Обработка документов НБО",
                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                   {
                                       new FullWindowAutoIt()
                                       {
                                           NameControl = "Подтверждение ввода документов",
                                           UserControl = new ConfirmationNbo()
                                       }
                                   }
                               }   
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "ИОН",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                   new FullWindowAutoIt()
                                   {
                                      NameControl = "Информационное обслуживание",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Формирование справки о наличии сальдо по инициативе НО",
                                              UserControl = new ViewFaceRegistryReference()
                                          },
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Журнал учета запросов НО",
                                              UserControl = new ViewFaceRegistryReferenceSend()
                                          }
                                      }
                                   }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Регистрация",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {

                          new FullWindowAutoIt()
                          {
                              NameControl = "Централизованная система регистрации",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Электронный архив",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Запросить электронные образы документов дела из архива(преобразование)",
                                              UserControl = new UserControlDocumentScan()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Документооборот",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Передача документов",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Комплектование тары",
                                              UserControl = new UserControlScanAddContainer()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Контрольная работа",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Допрос свидетелей",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Инициализация процедуры допроса свидетеля",
                                              UserControl = new InterrogationOfWitnessesView()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Учет документов",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "Прием документов учета НП",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Прием документов учета НП (ФЛ)",
                                              UserControl = new UserControlAcceptanceDocuments()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Банковские и лицевые счета",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "06. Журналы принятых файлов БС",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "01. Визуальный анализ сообщений банка",
                                              UserControl = new VisualBank()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Общие задания",
                              CollectionUserControl =
                                  new ObservableCollection<FullWindowAutoIt>()
                                  {
                                      new FullWindowAutoIt()
                                      {
                                          NameControl = "Уточнение сведений о ФЛ",
                                          UserControl = new Form.Automat.Registration.UtochneneeSved.UserControl.YtochnenieSved(ytochnenieSved)
                                      }
                                  }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Собственность",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "05-06-07. Росреестр – Земельные участки/Имущество/Транспорт",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "05.03,06-03,07-02 Обработка данных веток",
                                              UserControl = new FpdZemly()
                                          }
                                      }
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "14. Работа с лицами – правообладателями объектов, по которым требуется визуальная обработка",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "01. Росреестр - ФЛ, 11. Росреестр - Запросы на обработку",
                                              UserControl = new UserControlRosreestr()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "ПОН ИЛ",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl =
                                          "1. ПОН ИЛ (ПЭ). Организации и физические лица, внесенные в ПОН ИЛ",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "2.01. ФЛ. Актуальное состояние",
                                              UserControl = new ActualStatus()
                                          }
                                      }
                                  }
                              }
                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Централизованный учет налогоплательщиков",
                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                              {
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "18. Действия к выполнению",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "2.09. Ручная идентификация физического лица",
                                              UserControl = new IdentificationFlView()
        }
                                      }
                                  },
                                  new FullWindowAutoIt()
                                  {
                                      NameControl = "15.02.02. Служебные. Технические исправления",
                                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                      {
                                          new FullWindowAutoIt()
                                          {
                                              NameControl = "Физические лица",
                                              CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                              {
                                                  new FullWindowAutoIt()
                                                  {
                                                      NameControl = "15.02.02.01. Служебные. Технические исправления. Физические лица",
                                                      UserControl = new TehnicalUpdate()
                                                  },
                                              }
                                          }
                                      }
                                  },
                                  new FullWindowAutoIt()
                                  {
                                   NameControl = "07. Учет физических лиц",
                                   CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                                    {
                                      new FullWindowAutoIt()
                                        {
                                         NameControl = "1.01. Журнал поступивших документов",
                                         UserControl = new ReceivedDocuments(ytochnenieSved)
                                        }
                                    }
                                 }
                              }
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Формирование Списков",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Автоматическое формирование списка по XML схеме!",
                              UserControl = new ViewGenerator()

                          },
                          new FullWindowAutoIt()
                          {
                              NameControl = "Формирование По XML Схеме!!!",
                              UserControl = new FormSpisok()
                          }
                      }
                  },
                  new FullWindowAutoIt()
                  {
                      NameControl = "Отчеты",
                      CollectionUserControl = new ObservableCollection<FullWindowAutoIt>()
                      {
                          new FullWindowAutoIt()
                          {
                              NameControl = "Отчеты по Автоматам!!!",
                              UserControl = new Report()
                          }
                      }
                  }

              };
              autoit.CollectionUserControl = window;
              return autoit;
        }
      }
    }
