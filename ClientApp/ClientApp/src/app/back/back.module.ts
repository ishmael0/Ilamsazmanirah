import { NgModule } from '@angular/core';
import { buildPath, buildPathFromConfig, TemplateModule } from '../../../../../../Santel/ClientApp/src/app/template/template.module';
import { RouterModule, Routes } from '@angular/router';
import { BaseModel, BaseModelWithTitle, ComponentTypes, EntityConfiguration, getNameOf, isUndefinedOrWhiteSpaces, PropertyConfiguration, Status, WebSiteConfiguration } from '../../../../../../Santel/ClientApp/src/app/services/utils';
import { WebSiteService } from '../../../../../../Santel/ClientApp/src/app/services/website.service';
import { Validators, FormGroup } from '@angular/forms';
import { ActiveStatus, defaultPropertyConfiguration, defaultPropertyWithTitleConfiguration, DeletedStatus, FullStatuses, PublishedStatus } from '../../../../../../Santel/ClientApp/src/app/services/properties';

import "reflect-metadata";

 
export class City extends BaseModelWithTitle {
}
 

export const config: WebSiteConfiguration = new WebSiteConfiguration('DB', 'مدیریت وب سایت ', ' ', [
  
  //new EntityConfiguration<City>("City", City, CityComponent, 'شهرستان', FullStatuses, [
  //  ...defaultPropertyWithTitleConfiguration,
  // ], {  componentType: ComponentTypes.table }),
   

], {});

@NgModule({
  declarations: [
 
 
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



