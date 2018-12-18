﻿import { NgModule } from '@angular/core';
import { RouterModule, Routes, ActivatedRoute } from '@angular/router';
import { Predproverka } from './Otdel/Predproverka/Soprovod/StartModule/Predproverka';
import { AnalizNo } from './Otdel/Analiticks/AnalizNo/StartModule/StartModuleAnaliz';
import { BdkIt } from './Otdel/It/Bdk/StartModule/Bdk';
import { BdkLetter } from './Otdel/It/FormLetter/StartModel/FormLetter';
import { AddTemplate } from './Otdel/It/AddTemplate/StartModel/AddTemplate';
import { ReshenieStart } from './Otdel/Yregulirovanie/Trebovanie/StartModule/Reshenie';
import { AppComponent } from './Otdel/Analiticks/FaceMerge/StartModule/StartComponent';
import { ChatComponent } from './Otdel/It/Chat/StartModule/Chat';
import { ConnectionResolver } from './Otdel/It/Chat/Model/Resolved';

const appRoutes: Routes = [
    {
        path: 'page1',
        component: BdkIt
    },
    {
        path: 'page2',
        component: BdkLetter
    },
    {
        path: 'page3',
        component: AddTemplate
    },
    {
        path: 'page4',
        component: ReshenieStart
    },
    {
        path: 'page5',
        component: AppComponent
    },
    {
        path: 'page6',
        component: AnalizNo
    } ,
    {
        path: 'page7',
        component: Predproverka
    },
    {
        path: 'page8',
        component: ChatComponent,
        resolve: { connection: ConnectionResolver }
    }
];

@NgModule({
    imports: [
        RouterModule.forRoot(
            appRoutes,
            {
                enableTracing: false // <-- debugging purposes only
            }
        )
    ],
     exports: [
        RouterModule
              ], providers: [ ConnectionResolver ]
})
export class AppRoutingModule { }


