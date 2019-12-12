import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appInputThousands]'
})
export class InputThousandsDirective {
  private elr: ElementRef;

  constructor(elr: ElementRef) {
    this.elr = elr;
  }

  ngOnInit() {
    this.addCommas(this.elr.nativeElement);
  }

  @HostListener('blur', ['$event']) onBlur(event) {
    const target = event.target;
    this.addCommas(target);
  }

  @HostListener('focus', ['$event']) onFocus(event) {
    const target = event.target;
    this.removeCommas(target);
  }

  addCommas(target) {
    const tmp = target.value.replace(/,/g, '');
    const val = Number(tmp).toLocaleString('en-CA');

    if (tmp === '') {
      target.value = '';
    } else if (val !== 'NaN') {
      target.value = val;
    }
  }

  removeCommas(target) {
    const val = target.value.replace(/[,]/g, '');

    target.value = val;
  }

}
