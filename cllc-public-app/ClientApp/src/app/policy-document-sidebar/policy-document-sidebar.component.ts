import { Component, Input } from '@angular/core';
import { PolicyDocumentDataService } from "../services/policy-document-data.service";
import { PolicyDocumentSummary } from "../models/policy-document-summary.model";
@Component({
    selector: 'app-policy-document-sidebar',
    templateUrl: './policy-document-sidebar.component.html',
    styleUrls: ['./policy-document-sidebar.component.scss']
})
/** PolicyDocumentSidebar component*/
export class PolicyDocumentSidebarComponent {
  _category: string;
  get category(): string{
    return this._category;
  }
  @Input('category') 
  set category(cat: string){
    this._category = cat;
    if(cat && cat.length){
      this.policyDocumentDataService.getPolicyDocuments(cat)
        .then((data) => {
          this.policyDocumentSummaries = data;
        });
    }
  }
  public policyDocumentSummaries:PolicyDocumentSummary[];
    /** PolicyDocumentSidebar ctor */
  constructor(private policyDocumentDataService: PolicyDocumentDataService) {
  }

  ngOnInit(): void {  
  }
}
