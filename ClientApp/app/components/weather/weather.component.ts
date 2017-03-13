import { Component } from '@angular/core';

@Component({
    selector: 'weather',
    templateUrl: './weather.component.html'
})
export class WeatherComponent {
    public title: string;
    public weather: IWeather;

    public constructor() {
        const self = this;

        self.title = 'Weather Check';
        self.weather = { temp: 68, summary: 'Okay weather in Washington', city: 'Kirkland' };
    }
}

interface IWeather {
    temp: number;
    summary: string;
    city: string;
}