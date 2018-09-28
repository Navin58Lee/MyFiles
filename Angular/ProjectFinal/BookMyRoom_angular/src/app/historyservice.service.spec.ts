import { TestBed, inject } from '@angular/core/testing';

import { HistoryserviceService } from './historyservice.service';

describe('HistoryserviceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HistoryserviceService]
    });
  });

  it('should be created', inject([HistoryserviceService], (service: HistoryserviceService) => {
    expect(service).toBeTruthy();
  }));
});
