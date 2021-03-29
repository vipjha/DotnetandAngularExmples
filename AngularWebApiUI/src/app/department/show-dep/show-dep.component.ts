import { SharedService } from './../../shared.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-show-dep',
  templateUrl: './show-dep.component.html',
  styleUrls: ['./show-dep.component.css']
})
export class ShowDepComponent implements OnInit {

  constructor(private service:SharedService) { }

  DepartmentList:any=[];

  ModalTitle:string;
  ActivatedAddEidtDepComp:boolean=false;
  dep:any;

  ngOnInit(): void {
    this.refreshDepList();
  }

  refreshDepList(){
    this.service.getDepList().subscribe(data=>{
      this.DepartmentList=data;
    });
  }
  addClick(){
    this.dep={
      DepartmentId:0,
      DepartmentName:""
    }
    this.ModalTitle="Add Department";
    this.ActivatedAddEidtDepComp=true;
  }

  closeClick(){
    this.ActivatedAddEidtDepComp=false;
    this.refreshDepList();
  }


}
