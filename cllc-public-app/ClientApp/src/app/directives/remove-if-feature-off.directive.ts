import { Directive, ElementRef, Input, OnInit } from "@angular/core";
import { FeatureFlagService } from "@services/feature-flag.service";

@Directive({
  selector: "[appRemoveIfFeatureOff]"
})
export class AppRemoveIfFeatureOffDirective implements OnInit {
  @Input("appRemoveIfFeatureOff")
  featureName: string;

  constructor(private el: ElementRef,
    private featureFlagService: FeatureFlagService) {
  }

  ngOnInit() {
    this.featureFlagService.featureOn(this.featureName)
      .subscribe((featureOn: boolean) => {
        if (!featureOn) {
          this.el.nativeElement.parentNode.removeChild(this.el.nativeElement);
        }
      });
  }
}
