import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { ActivatedRoute, Params } from "@angular/router";
import { AppState } from "@app/app-state/models/app-state";
import { Contact } from "@models/contact.model";
import { SepApplication } from "@models/sep-application.model";
import { SepSchedule } from "@models/sep-schedule.model";
import { Store } from "@ngrx/store";
import { ContactDataService } from "@services/contact-data.service";
import { IndexedDBService } from "@services/indexed-db.service";
import { PaymentDataService } from "@services/payment-data.service";
import { SpecialEventsDataService } from "@services/special-events-data.service";
import { map, mergeMap } from "rxjs/operators";
import {
  faAward,
  faBirthdayCake,
  faBolt,
  faBusinessTime,
  faCalendarAlt,
  faCertificate,
  faCheck,
  faDownload,
  faExchangeAlt,
  faExclamationTriangle,
  faFlag,
  faPencilAlt,
  faQuestionCircle,
  faShoppingCart,
  faStopwatch,
  faTrashAlt,
  IconDefinition
} from "@fortawesome/free-solid-svg-icons";
import {
  faBan
} from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: "app-summary",
  templateUrl: "./summary.component.html",
  styleUrls: ["./summary.component.scss"]
})
export class SummaryComponent implements OnInit {
  @Input() account: any; // TODO: change to Account and fix prod error
  @Output() saveComplete = new EventEmitter<boolean>();
  mode: "readonlySummary" | "pendingReview" | "payNow" = "readonlySummary";
  _appID: number;
  application: SepApplication;
  faDownLoad = faDownload;
  faExclamationTriangle = faExclamationTriangle;
  faFlag = faFlag;
  faQuestionCircle = faQuestionCircle;
  faPencilAlt = faPencilAlt;
  faStopwatch = faStopwatch;
  faCertificate = faCertificate;
  faShoppingCart = faShoppingCart;
  faTrashAlt = faTrashAlt;
  faCalendarAlt = faCalendarAlt;
  faBusinessTime = faBusinessTime;
  faExchangeAlt = faExchangeAlt;
  faBirthdayCake = faBirthdayCake;
  faBolt = faBolt;
  faCheck = faCheck;
  faBan = faBan;
  /**
   * Controls whether or not the form show the submit button.
   * The value true by default
   */
  @Input() showSubmitButton = true;
  contact: Contact;
  transactionId: any;
  appId: any;
  retryCount: any;
  cardType: string;
  authCode: any;
  avsMessage: any;
  avsAddrMatch: any;
  messageId: any;
  messageText: any;
  paymentMethod: any;
  trnAmount: any;
  trnApproved: any;
  trnDate: any;
  trnId: any;
  trnOrderNumber: any;
  invoice: any;
  isApproved: boolean;
  paymentTransactionTitle: string;
  paymentTransactionMessage: string;
  loaded: boolean;
  savingToAPI: boolean;

  @Input() set localId(value: number) {
    this._appID = value;
    // get the last saved application
    this.db.getSepApplication(value)
      .then(app => {
        this.application = app;
        this.formatEventDatesForDisplay();
      });
  }

  get localId() {
    return this._appID;
  }

  constructor(private db: IndexedDBService,
    private snackBar: MatSnackBar,
    private route: ActivatedRoute,
    private store: Store<AppState>,
    private paymentDataService: PaymentDataService,
    private sepDataService: SpecialEventsDataService,
    private contactDataService: ContactDataService) {
    this.store.select(state => state.currentUserState.currentUser)
      .subscribe(user => {
        this.contactDataService.getContact(user.contactid)
          .subscribe(contact => {
            this.contact = contact;
          });
      });

    this.route.queryParams.subscribe(params => {
      this.transactionId = params["trnId"];
      this.appId = params["SessionKey"];
    });
    this.route.params.subscribe((params: Params) => {
      const id = params.apiId;

      if (id) {
        sepDataService.getSpecialEventForApplicant(id)
          .subscribe(app => {
            this.showSubmitButton = false;
            this.application = app;
            this.formatEventDatesForDisplay();
          });
      }
    });
  }

  ngOnInit(): void {
    if (this.transactionId) {
      this.verify_payment();
    }
  }

  /**
 * Payment verification
 * */
  verify_payment() {
    this.retryCount++;
    this.paymentDataService.verifyPaymentURI("specialEventInvoice", this.appId).subscribe(
      res => {
        const verifyPayResponse = res as any;
        // console.log(verifyPayResponse);
        switch (verifyPayResponse.cardType) {
          case "VI":
            this.cardType = "Visa";
            break;
          case "PV":
            this.cardType = "Visa Debit";
            break;
          case "MC":
            this.cardType = "MasterCard";
            break;
          case "AM":
            this.cardType = "American Express";
            break;
          case "MD":
            this.cardType = "Debit MasterCard";
            break;
          default:
            this.cardType = verifyPayResponse.cardType;
        }
        this.authCode = verifyPayResponse.authCode;
        this.avsMessage = verifyPayResponse.avsMessage;
        this.avsAddrMatch = verifyPayResponse.avsAddrMatch;
        this.messageId = verifyPayResponse.messageId;
        this.messageText = verifyPayResponse.messageText;
        this.paymentMethod = verifyPayResponse.paymentMethod;
        this.trnAmount = verifyPayResponse.trnAmount;
        this.trnApproved = verifyPayResponse.trnApproved;
        this.trnDate = verifyPayResponse.trnDate;
        this.trnId = verifyPayResponse.trnId;
        this.trnOrderNumber = verifyPayResponse.trnOrderNumber;
        this.invoice = verifyPayResponse.invoice;

        if (this.trnApproved === "1") {
          this.isApproved = true;
        } else {
          this.isApproved = false;
          if (this.messageId === "559") {
            this.paymentTransactionTitle = "Cancelled";
            this.paymentTransactionMessage = `Your payment transaction was cancelled. <br><br>
                <p>Please note, your application remains listed under Applications In Progress. </p>`;
          } else if (this.messageId === "7") {
            this.paymentTransactionTitle = "Declined";
            this.paymentTransactionMessage = `Your payment transaction was declined. <br><br>
                <p>Please note, your application remains listed under Applications In Progress. </p>`;
          } else {
            this.paymentTransactionTitle = "Declined";
            this.paymentTransactionMessage =
              `Your payment transaction was declined. Please contact your bank for more information. <br><br>
              <p>Please note, your application remains listed under Applications In Progress. </p>`;
          }
        }

        this.loaded = true;
      },
      err => {
        if (err === "503") {
          if (this.retryCount < 30) {
            this.snackBar.open(`Attempt ${this.retryCount} at payment verification, please wait...`,
              "Verifying Payment",
              { duration: 3500, panelClass: ["red - snackbar"] });
            this.verify_payment();
          }
        } else {
          this.snackBar.open("An unexpected error occured, please contact the branch to check if payment was processed",
            "Verifying Payment",
            { duration: 3500, panelClass: ["red - snackbar"] });
          console.log("Unexpected Error occured:");
          console.log(err);
        }

      }
    );
  }

  formatEventDatesForDisplay() {
    if (this?.application?.eventLocations?.length > 0) {
      this.application.eventLocations.forEach(loc => {
        if (loc.eventDates?.length > 0) {
          const formatterdDates = [];
          loc.eventDates.forEach(ed => {
            ed = Object.assign(new SepSchedule(null), ed);
            formatterdDates.push({ ed, ...ed.toEventFormValue() });
          });
          loc.eventDates = formatterdDates;
        }
      });
    }
  }

  getStatusIcon(): IconDefinition {
    switch(this.application?.eventStatus){
      case ("Pending Review"):
        return faStopwatch;
      case ("Approved"):
      case ("Reviewed"):
        return faCheck;
      case ("Issued"):
        return faAward;
      case ("Denied"):
      case ("Cancelled"):
        return faBan;
      default:
        return faStopwatch;
    }
  }

  isReviewed(): boolean {
    return ["Approved", "Issued"].indexOf(this.application?.eventStatus) >= 0;
  }

  isDenied(): boolean {
    return false;
  }

  isReadOnly(): boolean {
    return ["Pending Review","Approved","Issued","Denied","Cancelled"].indexOf(this.application?.eventStatus) >= 0;
  }

  async submitApplication(): Promise<void> {
    this.savingToAPI = true;

    const appData = await this.db.getSepApplication(this.localId);
    if (appData.id) { // do an update ( the record exists in dynamics)
      const result = await this.sepDataService.updateSepApplication({ ...appData, eventStatus: "Submitted" } as SepApplication, appData.id)
        .toPromise();
      if (result.eventStatus === "Approved") {
        this.mode = "payNow";
      } else if (result.eventStatus === "Pending Review") {
        this.mode = "pendingReview";
      }
      if (result.localId) {
        await this.db.applications.update(result.localId, result);
        this.localId = this.localId; // trigger data refresh
      }
    //} else {
    //  const result = await this.sepDataService.createSepApplication({})

    }
    this.savingToAPI = false;
  }

  payNow() {
    // and payment is required due to an invoice being generated
    if (this?.application?.id) {
      // proceed to payment
      this.submitPayment()
        .subscribe(res => {
        },
          error => {
            this.snackBar.open("Error submitting payment", "Fail", { duration: 3500, panelClass: ["red-snackbar"] });
          }
        );
    }
  }

  /**
 * Redirect to payment processing page (Express Pay / Bambora service)
 * */
  private submitPayment() {
    return this.paymentDataService.getPaymentURI("specialEventInvoice", this.application.id)
      .pipe(map(jsonUrl => {
        window.location.href = jsonUrl["url"];
        return jsonUrl["url"];
      }, (err: any) => {
        if (err._body === "Payment already made") {
          this.snackBar.open("Application payment has already been made.", "Fail", { duration: 3500, panelClass: ["red-snackbar"] });
        }
      }));
  }
}


