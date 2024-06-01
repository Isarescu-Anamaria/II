import { Component } from '@angular/core';
import { Angajat } from 'src/app/models/angajat.model';


@Component({
  selector: 'app-angajati-list',
  standalone: true,
  imports: [],
  templateUrl: './angajati-list.component.html',
  styleUrl: './angajati-list.component.css'
})
export class AngajatiListComponent {
  angajati: Angajat[] = [
    {
      id: "1",
      name: "Nume angajat1",
      email:"email@angajat1",
      phone: 998877665,
      department: "Departament angajat1",
      salary: 1000
    },
    {
      id: "2",
      name: "Nume angajat2",
      email:"email@angajat2",
      phone: 88554477,
      department: "Departament angajat2",
      salary: 100
    },
    {
      id: "3",
      name: "Nume angajat3",
      email:"email@angajat3",
      phone: 5544778899,
      department: "Departament angajat3",
      salary: 1500
    }
  ];
}
