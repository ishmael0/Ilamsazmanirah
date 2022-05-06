import { NgModule } from '@angular/core';
import { buildPath, buildPathFromConfig, TemplateModule } from '../../../../../../Santel/ClientApp/src/app/template/template.module';
import { RouterModule, Routes } from '@angular/router';
import { BaseModel, BaseModelWithTitle, ComponentTypes, EntityConfiguration, getNameOf, isUndefinedOrWhiteSpaces, PropertyConfiguration, Status, WebSiteConfiguration } from '../../../../../../Santel/ClientApp/src/app/services/utils';
import { WebSiteService } from '../../../../../../Santel/ClientApp/src/app/services/website.service';
import { Validators, FormGroup } from '@angular/forms';
import { ActiveStatus, defaultPropertyConfiguration, defaultPropertyWithTitleConfiguration, defaultStatuses, DeletedStatus, FullStatuses, PublishedStatus } from '../../../../../../Santel/ClientApp/src/app/services/properties';

import "reflect-metadata";
import { CityComponent, VahedComponent } from './components';

 
export class Vahed extends BaseModel {
  Titletest = 'hi';
}
export class City extends BaseModelWithTitle {
}
 

export const config: WebSiteConfiguration = new WebSiteConfiguration('DB', 'مدیریت وب سایت ', '', [
  
  new EntityConfiguration<City>("City", City, CityComponent, 'شهرستان', defaultStatuses, [
     ...defaultPropertyWithTitleConfiguration,
  ], { componentType: ComponentTypes.table, icon: 'city-variant-outline' }),

  new EntityConfiguration<Vahed>("Vahed", Vahed, VahedComponent, 'واحد', defaultStatuses, [
    ...defaultPropertyConfiguration,
    new PropertyConfiguration<Vahed>(c => c.Titletest, 'test  ', {   Type: 'string', InPicker: true, Validators: [] })
  ], { componentType: ComponentTypes.lazytable, icon: 'office-building' }),

], {});

@NgModule({
  declarations: [
 
    CityComponent, VahedComponent
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



