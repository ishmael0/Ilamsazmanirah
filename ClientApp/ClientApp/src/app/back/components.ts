import { Component, OnInit, ChangeDetectionStrategy, Injector } from '@angular/core';
import { BaseComponent } from '../../../../../../Santel/ClientApp/src/app/template/base/base.component';
import { NzFormatEmitEvent, NzTreeComponent, NzTreeNodeOptions } from 'ng-zorro-antd/tree';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { getNameOf, HTTPTypes, numberToText, RequestPlus, ValueTitle } from '../../../../../../Santel/ClientApp/src/app/services/utils';
import { City, Organization, SellMethod, Vahed } from './back.module';







@Component({
  selector: 'app-organization',
  templateUrl: './organization.component.html',
  styles: [
  ],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class OrganizationComponent extends BaseComponent<Organization> {
}


@Component({
  selector: 'app-sell-method',
  templateUrl: './sell-method.component.html',
  styles: [
  ],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class SellMethodComponent extends BaseComponent<SellMethod> {
}



@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styles: [
  ],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class CityComponent extends BaseComponent<City> {
}

@Component({
  selector: 'app-vahed',
  templateUrl: './vahed.component.html',
  styles: [
  ],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class VahedComponent extends BaseComponent<Vahed> {
  override async fill() {
    this.listCache.cities = this.dataManager.getLoadedData(City);
    this.listCache.sellMethods = this.dataManager.getLoadedData(SellMethod);
    this.listCache.organizations = this.dataManager.getLoadedData(Organization);
    this.listCache.VaziateVahed = [new ValueTitle<number>(1, 'آپارتمانی'), new ValueTitle<number>(2, 'ویلایی')];
    this.listCache.VaziateSanad = [new ValueTitle<number>(0, 'فاقد سند'), new ValueTitle<number>(1, 'دارای سند')]
    this.listCache.VaziateForoosh = [new ValueTitle<number>(1, 'فروش رفته'), new ValueTitle<number>(0, 'فروش نرفته')]
  }

  docU = '';
  docId = 0;
  imageModal = false;
  addDoc(e: string[]) {
    this.imageModal = false;
    let x: any[] = this.selectedForm().form.controls[this.docU].value;
    for (var i = 0; i < e.length; i++) {
      x.push({ Url: e[i], Title: '' });
    }
    this.selectedForm().form.controls[this.docU].setValue(x);
    this.makeItDirty(this.selectedForm().form);
  }
}

