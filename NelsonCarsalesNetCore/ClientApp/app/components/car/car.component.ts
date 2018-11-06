import { Component, OnInit } from '@angular/core';
import { Car } from '../../models/index';
import { CarService } from '../../services/index';
import { ToastrService } from 'toastr-ng2';
import { InputTextModule, DataTableModule, ButtonModule, DialogModule } from 'primeng/primeng';

class CarInfo implements Car {
    constructor(public networkId?: any, public displayTitle?: any, public siloTypeFriendlyName?: any, public siloTypeColour?: any, public displayLocation?: any) { }
}

@Component({
    selector: 'car',
    templateUrl: './car.component.html'
})
export class CarComponent implements OnInit {

    private rowData: any[];
    displayDialog: boolean;
    displayDeleteDialog: boolean;
    newContact: boolean;
    contact: Car = new CarInfo();
    contacts: Car[];
    public editContactId: any;
    public fullname: string;

    constructor(private carService: CarService, private toastrService: ToastrService) {

    }

    ngOnInit() {
        this.editContactId = 0;
        this.loadData();
    }

    loadData() {
        this.carService.getCars()
            .subscribe(res => {
                console.log('result in browser ' + res.result);
                this.rowData = res.result;
            });
    }

  
}