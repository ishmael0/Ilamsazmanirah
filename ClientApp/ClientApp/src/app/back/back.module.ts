import { NgModule } from '@angular/core';
import { buildPath, buildPathFromConfig, TemplateModule } from '../../../../../../Santel/ClientApp/src/app/template/template.module';
import { RouterModule, Routes } from '@angular/router';
import { BaseModel, BaseModelWithTitle, ComponentTypes, EntityConfiguration, getNameOf, isUndefinedOrWhiteSpaces, PropertyConfiguration, Status, ValueTitle, WebSiteConfiguration } from '../../../../../../Santel/ClientApp/src/app/services/utils';
import { WebSiteService } from '../../../../../../Santel/ClientApp/src/app/services/website.service';
import { Validators, FormGroup } from '@angular/forms';
import { ActiveStatus, CreateProperty, defaultPropertyConfiguration, defaultPropertyWithTitleConfiguration, defaultStatuses, DeletedStatus, FullStatuses, IdProperty, PublishedStatus } from '../../../../../../Santel/ClientApp/src/app/services/properties';

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
  VaziateForoosh: number = 0;
  CityId!: number;
  Code: string = "";
  VaziateSanad: number = 0;
  NameBahreBardar: string = "";
  FamilyBahreBardar: string = "";
  SematBahreBardar: string = "";
  DastgaheMoarrefiKonnande!: number;
  GharardadShomare: string = "";
  GharardadTarikh: string = "";
  GharardadModdat: string = "";
  GharardadEjare: string = "";
  Ejare98: number = 0;
  Ejare99: number = 0;
  MablaghNamayandegi: number = 0;
  ArzesheKarshenasi: number = 0;
  ElamBeDarayi: number = 0;
  NahveForoosh!: number;
  ShomareVagozari: string = "";
  TarikhVagozari: string = "";
  ShomareNamayandegi: string = "";
  TarikhNamayandegi: string = "";
  VaziateVahed: number = 0;
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
  new EntityConfiguration<SellMethod>("SellMethod", SellMethod, SellMethodComponent, 'نحوه فروش خانه های سازمانی', defaultStatuses, [
    ...defaultPropertyWithTitleConfiguration,
  ], { componentType: ComponentTypes.table, icon: 'city-variant-outline' }),
  new EntityConfiguration<Organization>("Organization", Organization, OrganizationComponent, 'دستگاه استفاده كننده', defaultStatuses, [
    ...defaultPropertyWithTitleConfiguration,
  ], { componentType: ComponentTypes.table, icon: 'city-variant-outline' }),
  new EntityConfiguration<Vahed>("Vahed", Vahed, VahedComponent, 'واحد های سازمانی', defaultStatuses, [
    IdProperty, CreateProperty,
    new PropertyConfiguration<BaseModel>(c => c.Status, ' وضعیت ', { InPicker: false, InTable: false, InSearch: false, Type: 'enum', value: 'Active' }),
    new PropertyConfiguration<Vahed>(c => c.ShomareVahed, 'شماره واحد', { Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.VaziateForoosh, 'وضعیت فروش', { TypeHelper: 'VaziateForoosh', Type: 'fromList', InPicker: true, Validators: [], }),
    new PropertyConfiguration<Vahed>(c => c.CityId, 'شهر', { TypeHelper: 'cities', InTable: true, Type: 'fromList', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Code, 'كد كاداستر پلاك زمین', { InTable: true, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.VaziateSanad, 'وضعیت سند', { InTable: false, Type: 'fromList', TypeHelper: 'VaziateSanad', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.NameBahreBardar, 'نام بهره بردار', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.FamilyBahreBardar, 'نام خانوادگی بهره بردار', { InTable: true, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.SematBahreBardar, 'سمت بهرهبردار', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.DastgaheMoarrefiKonnande, 'دستگاه معرفی كننده', { InTable: true, TypeHelper: 'organizations', Type: 'fromList', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadShomare, 'وضعیت قرارداد-شماره', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadTarikh, 'وضعیت قرارداد-تاریخ', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadModdat, 'وضعیت قرارداد-مدت', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.GharardadEjare, 'وضعیت قرارداداجاره ماهانه', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Ejare98, 'اجاره پرداختی سال98', { InTable: false, Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Ejare99, 'اجاره پرداختی سال99', { InTable: false, Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.MablaghNamayandegi, 'مبلغ نمایندگی', { InTable: false, Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ArzesheKarshenasi, 'ارزش كارشناسی', { InTable: false, Type: 'number', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ElamBeDarayi, 'اعلام نهایی به وزارت یا داریی', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.NahveForoosh, 'نحوه فروش', { TypeHelper: 'sellMethods', InTable: false, Type: 'fromList', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ShomareVagozari, 'شماره واگذاری', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.TarikhVagozari, 'تاریخ واگذاری', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.ShomareNamayandegi, 'شماره نمایندگی', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.TarikhNamayandegi, 'تاریخ نمایندگی', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.VaziateVahed, 'وضعیت واحد', { InTable: true, TypeHelper: 'VaziateVahed', Type: 'fromList', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Address, 'آدرس', { InTable: true, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Description, 'توضیحات', { InTable: false, Type: 'string', InPicker: true, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Gharardad, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.HeyatNamayandegi, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Estelam, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Karshenasi, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.EjareName, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.MadrakGhabli, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.MadrakFeli, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Korooki, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.Sanad, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] }),
    new PropertyConfiguration<Vahed>(c => c.SayerMostanadat, '', { InTable: false, Type: 'object', InSearch: false, InExport: false, Validators: [] })


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



