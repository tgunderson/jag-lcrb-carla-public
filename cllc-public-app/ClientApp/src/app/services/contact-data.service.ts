import { Injectable } from "@angular/core";

import { HttpClient } from "@angular/common/http";

import { Contact, PHSContact, CASSContact } from "@models/contact.model";
import { DataService } from "./data.service";
import { catchError } from "rxjs/operators";

@Injectable()
export class ContactDataService extends DataService {

  apiPath = "api/contact/";

  constructor(private http: HttpClient) {
    super();
  }

  getContact(contactId: string) {
    return this.http.get<Contact>(this.apiPath + contactId, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getContactPhsLink(contactId: string) {
    return this.http.get<string>(`${this.apiPath}phs-link/${contactId}`, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getContactByPhsToken(token: string) {
    return this.http.get<PHSContact>(`${this.apiPath}phs/${encodeURIComponent(token)}`, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getContactByCassToken(token: string) {
    return this.http.get<CASSContact>(`${this.apiPath}cass/${encodeURIComponent(token)}`, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  createContact(contact: Contact) {
    return this.http.post<Contact>(this.apiPath, contact, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  createWorkerContact(contact: Contact) {
    return this.http.post<Contact>(this.apiPath + "worker", contact, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  updateContact(contact: Contact) {
    return this.http.put<Contact>(this.apiPath + contact.id, contact, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  updateContactByToken(contact: Contact, token: string) {
    return this.http.put<Contact>(this.apiPath + "security-screening/" + encodeURIComponent(token),
        contact,
        { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

}
