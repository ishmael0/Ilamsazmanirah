import { NgModule } from '@angular/core';
import { buildPath, buildPathFromConfig, TemplateModule } from '../../../../../../Santel/ClientApp/src/app/template/template.module';
import { RouterModule, Routes } from '@angular/router';
import { BaseModel, BaseModelWithTitle, ComponentTypes, EntityConfiguration, getNameOf, isUndefinedOrWhiteSpaces, PropertyConfiguration, Status, ValueTitle, WebSiteConfiguration } from '../../../../../../Santel/ClientApp/src/app/services/utils';
import { WebSiteService } from '../../../../../../Santel/ClientApp/src/app/services/website.service';
import { Validators, FormGroup } from '@angular/forms';
import { ActiveStatus, defaultPropertyConfiguration, defaultPropertyWithTitleConfiguration, defaultStatuses, DeletedStatus, FullStatuses, PublishedStatus } from '../../../../../../Santel/ClientApp/src/app/services/properties';

import "reflect-metadata";
import { CityComponent, OrganizationComponent, SellMethodComponent, VahedComponent } from './components';



export class City extends BaseModelWithTitle {
}
export class SellMethod extends BaseModelWithTitle {
}
export class Organization extends BaseModelWithTitle {
}


export class Vahed extends BaseModel {
  ShomareVahed: string = "";
  VaziateForoosh : number=0;
  CityId!: number;
  Code: string = "";
  VaziateSanad : number = 0;
  NameBahreBardar: string = "";
  FamilyBahreBardar: string = "";
  SematBahreBardar: string = "";
  DastgaheMoarrefiKonnande! : number ;
  GharardadShomare: string = "";
  GharardadTarikh: string = "";
  GharardadModdat: string = "";
  GharardadEjare: string = "";
  Ejare98 : number = 0;
  Ejare99 : number = 0;
  MablaghNamayandegi : number = 0;
  ArzesheKarshenasi : number = 0;
  ElamBeDarayi : number = 0;
  NahveForoosh! : number;
  ShomareVagozari: string = "";
  TarikhVagozari : string="";
  ShomareNamayandegi: string = "";
  TarikhNamayandegi: string = "";
  VaziateVahed : number = 0;
  Address: string = "";
  Description: string = "";
  Gharardad: Document[] = [];
  HeyatNamayandegi: Document[] = [];
  Estelam: Document[] = [];
  Karshenasi: Document[] = [];
  EjareName: Document[] = [];
  MadrakGhabli: Document[] = [];
  MadrakFeli: Document[] = [];
  Korooki: Document[] = [];
  Sanad: Document[] = [];
  SayerMostanadat: Document[] = [];
}

export interface Document {
  Title: string;
  Url: string;
}







export const config: WebSiteConfiguration = new WebSiteConfiguration('DB', 'مدیریت وب سایت ', '', [

  new EntityConfiguration<City>("City", City, CityComponent, 'شهرستان', defaultStatuses, [
    ...defaultPropertyWithTitleConfiguration,
  ], { componentType: ComponentTypes.table, icon: 'city-variant-outline' }),
  new EntityConfiguration<SellMethod>("SellMethod", SellMethod, SellMethodComponent, 'نحوه فروش', defaultStatuses, [
    ...defaultPropertyWithTitleConfiguration,
  ], { componentType: ComponentTypes.table, icon: 'city-variant-outline' }),
  new EntityConfiguration<Organization>("Organization", Organization, OrganizationComponent, 'دستگاه', defaultStatuses, [
    ...defaultPropertyWithTitleConfiguration,
  ], { componentType: ComponentTypes.table, icon: 'city-variant-outline' }),
  new EntityConfiguration<Vahed>("Vahed", Vahed, VahedComponent, 'واحد', defaultStatuses, [
    ...defaultPropertyConfiguration,

    new PropertyConfiguration<Vahed>(c => c.ShomareVahed, 'شماره واحد', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.VaziateForoosh, 'وضعیت فروش', { TypeHelper: 'VaziateForoosh',     Type: 'list', InPicker: true, Validators: [],    }),
    new PropertyConfiguration<Vahed>(c => c.CityId, 'شهر', { TypeHelper:'cities', Type: 'list', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Code, 'كد كاداستر پلاك زمين', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.VaziateSanad, 'وضعیت سند', { Type: 'list', TypeHelper:'VaziateSanad', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.NameBahreBardar, 'نام بهره بردار', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.FamilyBahreBardar, 'نام خانوادگی بهره بردار', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.SematBahreBardar, 'سمت بهرهبردار', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.DastgaheMoarrefiKonnande, 'دستگاه معرفي كننده', { TypeHelper:'organizations', Type: 'list', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadShomare, 'وضعيت قرارداد-شماره', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadTarikh, 'وضعيت قرارداد-تاریخ', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadModdat, 'وضعيت قرارداد-مدت', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadEjare, 'وضعيت قرارداداجاره ماهانه', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Ejare98, 'اجاره پرداختی سال98', { Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Ejare99, 'اجاره پرداختی سال99', { Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.MablaghNamayandegi, 'مبلغ نمايندگي', { Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ArzesheKarshenasi, 'ارزش كارشناسي', { Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ElamBeDarayi, 'اعلام نهايي به وزارت يا داريي', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.NahveForoosh, 'نحوه فروش', { TypeHelper:'sellMethods', Type: 'list', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ShomareVagozari, 'شماره واگذاري', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.TarikhVagozari, 'تاريخ واگذاري', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ShomareNamayandegi, 'شماره نمايندگي', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.TarikhNamayandegi, 'تاريخ نمايندگي', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.VaziateVahed, 'وضعيت واحد', { TypeHelper:'VaziateVahed', Type: 'list', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Address, 'آدرس', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Description, 'توضيحات', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Gharardad, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.HeyatNamayandegi, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Estelam, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Karshenasi, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.EjareName, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.MadrakGhabli, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.MadrakFeli, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Korooki, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Sanad, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.SayerMostanadat, '', { Type: 'object', InSearch: false, InTable: false, InExport: false, Validators: [] })


  ], {
    componentType: ComponentTypes.lazytable, icon: 'office-building',
    neededData: [City, Organization, SellMethod],
    getTitle: (item: FormGroup) => { return item.controls['ShomareVahed']?.value ?? "جدید"; }
  }),

], {});

@NgModule({
  declarations: [

    CityComponent, VahedComponent, SellMethodComponent, OrganizationComponent
  ],
  imports: [
    TemplateModule,
    //CKEditorModule,
    RouterModule.forChild(buildPathFromConfig(config))
  ]
})
export class BackModule {
  constructor(wss: WebSiteService) {
    wss.websites.push(config);
    wss.selectedWebsite = config;
  }
}



