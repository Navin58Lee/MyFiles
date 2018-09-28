import { TestBed, inject } from '@angular/core/testing';

import { BookingdetailsService } from './bookingdetails.service';

describe('BookingdetailsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BookingdetailsService]
    });
  });

  it('should be created', inject([BookingdetailsService], (service: BookingdetailsService) => {
    expect(service).toBeTruthy();
  }));
});
